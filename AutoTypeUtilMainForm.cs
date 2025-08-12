using System.Reflection.Emit;
using System.Windows.Forms;

namespace AutoTypeUtil2
{
    public partial class AutoTypeUtilMain : Form
    {
        KeyboardHook hook = new KeyboardHook();
        bool pasteFromClipboard = false;
        public AutoTypeUtilMain()
        {
            InitializeComponent();
            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            uint modifier_calc = 0;
            foreach (string modifier_key in Properties.Settings.Default.HotKeyModifiers.Split(','))
            {
                modifier_calc += (uint)Enum.Parse(typeof(AutoTypeUtil2.ModifierKeys), modifier_key);
            }
            AutoType_PasteClipboardCheckBox.CheckState = Properties.Settings.Default.PasteFromClipboard ? CheckState.Checked : CheckState.Unchecked;
            this.pasteFromClipboard = Properties.Settings.Default.PasteFromClipboard;
            AutoTypeUtil2.ModifierKeys ModifierFromSettings = (AutoTypeUtil2.ModifierKeys)modifier_calc;
            Keys KeyFromSettings = (Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.HotkeyKey);
            hook.RegisterHotKey(ModifierFromSettings, KeyFromSettings);

            AutoTypeUtil_DelayBox.Text = $"{Properties.Settings.Default.DelayMilliseconds}";
            AutoType_HideTextCheckBox.Checked = Properties.Settings.Default.HiddenText;
            }
        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // https://stackoverflow.com/questions/5282588/how-can-i-bring-my-application-window-to-the-front
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }
        private void MainWindow_OnClosing(System.Object sender, System.EventArgs e)
        {
            //Properties.Settings.Default.DelayMilliseconds = 1000;
          //  Properties.Settings.Default.Save();
            Application.Exit();
        }
        private async void AutoTypeUtil_SaveButton_Click(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Save Clicked");
            System.Diagnostics.Debug.WriteLine($"Saving Hidden Text Default: '{AutoType_HideTextCheckBox.Checked}'");
            Properties.Settings.Default.HiddenText = AutoType_HideTextCheckBox.Checked;
            Int32 delaynumber;
            System.Diagnostics.Debug.WriteLine($"Try parse delay value: '{AutoTypeUtil_DelayBox.Text}'");
            bool success = Int32.TryParse(AutoTypeUtil_DelayBox.Text, out delaynumber);
            System.Diagnostics.Debug.WriteLine($"Succeeded parsing delay value?: [{success}], {delaynumber}ms.");
            if (success)
            {
                Properties.Settings.Default.DelayMilliseconds = delaynumber;
            } else
            {
                System.Diagnostics.Debug.WriteLine($"Couldn't parse delay, not saving");
            }
// AutoType_PasteClipboardCheckBox.CheckState = Properties.Settings.Default.PasteFromClipboard ? CheckState.Checked : CheckState.Unchecked;
            Properties.Settings.Default.PasteFromClipboard = AutoType_PasteClipboardCheckBox.CheckState == CheckState.Checked ? true : false;
            Properties.Settings.Default.Save();
            System.DateTime nowTimeStamp = System.DateTime.Now;
            System.Diagnostics.Debug.WriteLine($"Saved Defaults... [{nowTimeStamp.ToString()}]");
            AutoTypeUtil_SaveLabel.Text = $"Saved: {System.DateTime.Now.ToString()}";
            FadeInLabel(AutoTypeUtil_SaveLabel);
            await Task.Delay(3000);
            FadeOutLabel(AutoTypeUtil_SaveLabel);

            // https://stackoverflow.com/questions/12497826/better-algorithm-to-fade-a-winform
        }
        private async void AutoType_Button_Click(System.Object sender, System.EventArgs e)
        {
            // MessageBox.Show(AutoType_TextBox.Text);
            System.Diagnostics.Debug.WriteLine("Start AutoType Event");
            String toType = pasteFromClipboard ? System.Windows.Forms.Clipboard.GetText() : AutoType_TextBox.Text;
            int delayMs = 0;
            try
            {
                if (AutoTypeUtil_DelayBox.Text != String.Empty)
                {
                    System.Diagnostics.Debug.WriteLine("Delay Textbox not empty, attempting to parse.");
                    delayMs = Int32.Parse(AutoTypeUtil_DelayBox.Text);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Delay Textbox is empty, assume 1000 delay");
                    delayMs = 1000;
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    System.Diagnostics.Debug.WriteLine($"Unparseable string in delay box: {AutoTypeUtil_DelayBox.Text}");

                    MessageBox.Show($"Unable to parse delay'{AutoTypeUtil_DelayBox.Text}");
                }
                else if (ex is ArgumentNullException)
                {
                    System.Diagnostics.Debug.WriteLine("If we ever have a null parse attempt something is wrong");
                    delayMs = 1000;
                }
                else
                {
                    MessageBox.Show($"Exception parsing Delay: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine("$Exception parsing Delay: {ex.Message}");

                }
            }
            if(toType == String.Empty)
            {
                System.Diagnostics.Debug.WriteLine($"Returning, Clipboard or textbox is empty.");
                return;

            }
            System.Diagnostics.Debug.WriteLine($"Writing Text: '{toType}' with delay '{delayMs}'");
            SendKeys.Send("%{Tab}");
            await Task.Delay((delayMs > 0) ? delayMs : 1000);  // 1000 or just nothing
            AutoTypeUtil2.Util.SendTextSpecialChars(toType);
            //  SendKeys.Send("%{Tab}");
        }
        private async void FadeInLabel(System.Windows.Forms.Label o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            o.Show();
                o.ForeColor = System.Drawing.Color.White;
                await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.WhiteSmoke;
            await Task.Delay(interval);
            o.ForeColor =System.Drawing.Color.Gray;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.DarkGray;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.Black;
            await Task.Delay(interval);

        }

        private async void FadeOutLabel(System.Windows.Forms.Label o, int interval = 80)
        {
            //Object is fully visible. Fade it out
            
                o.ForeColor =  System.Drawing.Color.Black;
                await Task.Delay(interval);
                o.ForeColor =  System.Drawing.Color.DarkGray;
                await Task.Delay(interval);
                o.ForeColor =  System.Drawing.Color.Gray;
                await Task.Delay(interval);
                o.ForeColor =  System.Drawing.Color.WhiteSmoke;
                await Task.Delay(interval);
                o.ForeColor =  System.Drawing.Color.White;
            await Task.Delay(interval);

            o.Hide();


        }
        private void  AutoType_PasteClipboardCheckBox_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Change Type From Clipboard state");
            if (AutoType_PasteClipboardCheckBox.Checked)
            {
                System.Diagnostics.Debug.WriteLine("We Paste from Clipboard now;");
                pasteFromClipboard = true;
                AutoType_TextBox.Enabled = false;
                AutoType_TextBox.Hide();
                AutoType_Button.Focus();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("We Paste from textbox now;");
                pasteFromClipboard = false;
                AutoType_TextBox.Enabled = true;
                AutoType_TextBox.Show();
                AutoType_TextBox.Focus();
            }
        }
        private void AutoType_HideTextCheckBox_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Change Textbox Mask state");
            if (AutoType_HideTextCheckBox.Checked)
            {
                System.Diagnostics.Debug.WriteLine($"Hide Text");

                AutoType_TextBox.UseSystemPasswordChar = false;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Show Text");
                AutoType_TextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
