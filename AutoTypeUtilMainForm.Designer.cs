namespace AutoTypeUtil2
{
    partial class AutoTypeUtilMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AutoType_Button = new Button();
            AutoType_HideTextCheckBox = new CheckBox();
            AutoType_TextBox = new TextBox();
            AutoTypeUtil_DelayBox = new TextBox();
            AutoType_DelayLabel = new Label();
            AutoTypeUtil_SaveButton = new Button();
            AutoTypeUtil_SaveLabel = new Label();
            AutoType_PasteClipboardCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // AutoType_Button
            // 
            AutoType_Button.Location = new Point(251, 40);
            AutoType_Button.Margin = new Padding(3, 4, 3, 4);
            AutoType_Button.Name = "AutoType_Button";
            AutoType_Button.Size = new Size(86, 31);
            AutoType_Button.TabIndex = 1;
            AutoType_Button.Text = "AutoType";
            AutoType_Button.UseVisualStyleBackColor = true;
            AutoType_Button.Click += AutoType_Button_Click;
            // 
            // AutoType_HideTextCheckBox
            // 
            AutoType_HideTextCheckBox.AutoSize = true;
            AutoType_HideTextCheckBox.Location = new Point(27, 107);
            AutoType_HideTextCheckBox.Margin = new Padding(3, 4, 3, 4);
            AutoType_HideTextCheckBox.Name = "AutoType_HideTextCheckBox";
            AutoType_HideTextCheckBox.Size = new Size(94, 24);
            AutoType_HideTextCheckBox.TabIndex = 2;
            AutoType_HideTextCheckBox.Text = "Hide Text";
            AutoType_HideTextCheckBox.UseVisualStyleBackColor = true;
            AutoType_HideTextCheckBox.CheckedChanged += AutoType_HideTextCheckBox_CheckedChanged;
            // 
            // AutoType_TextBox
            // 
            AutoType_TextBox.Location = new Point(27, 40);
            AutoType_TextBox.Margin = new Padding(3, 4, 3, 4);
            AutoType_TextBox.Multiline = true;
            AutoType_TextBox.Name = "AutoType_TextBox";
            AutoType_TextBox.PasswordChar = '*';
            AutoType_TextBox.PlaceholderText = "<Enter Text Here>";
            AutoType_TextBox.Size = new Size(217, 29);
            AutoType_TextBox.TabIndex = 0;
            AutoType_TextBox.UseSystemPasswordChar = true;
            // 
            // AutoTypeUtil_DelayBox
            // 
            AutoTypeUtil_DelayBox.Location = new Point(27, 160);
            AutoTypeUtil_DelayBox.Margin = new Padding(3, 4, 3, 4);
            AutoTypeUtil_DelayBox.Name = "AutoTypeUtil_DelayBox";
            AutoTypeUtil_DelayBox.PlaceholderText = "1000";
            AutoTypeUtil_DelayBox.Size = new Size(114, 27);
            AutoTypeUtil_DelayBox.TabIndex = 4;
            // 
            // AutoType_DelayLabel
            // 
            AutoType_DelayLabel.AutoSize = true;
            AutoType_DelayLabel.Location = new Point(27, 133);
            AutoType_DelayLabel.Name = "AutoType_DelayLabel";
            AutoType_DelayLabel.Size = new Size(83, 20);
            AutoType_DelayLabel.TabIndex = 4;
            AutoType_DelayLabel.Text = "Delay (ms):";
            // 
            // AutoTypeUtil_SaveButton
            // 
            AutoTypeUtil_SaveButton.BackgroundImage = Properties.Resources.SaveIcon_Orig;
            AutoTypeUtil_SaveButton.BackgroundImageLayout = ImageLayout.Stretch;
            AutoTypeUtil_SaveButton.Location = new Point(303, 167);
            AutoTypeUtil_SaveButton.Margin = new Padding(3, 4, 3, 4);
            AutoTypeUtil_SaveButton.Name = "AutoTypeUtil_SaveButton";
            AutoTypeUtil_SaveButton.Size = new Size(34, 40);
            AutoTypeUtil_SaveButton.TabIndex = 5;
            AutoTypeUtil_SaveButton.UseVisualStyleBackColor = true;
            AutoTypeUtil_SaveButton.Click += AutoTypeUtil_SaveButton_Click;
            // 
            // AutoTypeUtil_SaveLabel
            // 
            AutoTypeUtil_SaveLabel.AutoSize = true;
            AutoTypeUtil_SaveLabel.Location = new Point(80, 195);
            AutoTypeUtil_SaveLabel.Name = "AutoTypeUtil_SaveLabel";
            AutoTypeUtil_SaveLabel.Size = new Size(102, 20);
            AutoTypeUtil_SaveLabel.TabIndex = 6;
            AutoTypeUtil_SaveLabel.Text = "Not Saved Yet";
            AutoTypeUtil_SaveLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AutoType_PasteClipboardCheckBox
            // 
            AutoType_PasteClipboardCheckBox.AutoSize = true;
            AutoType_PasteClipboardCheckBox.Location = new Point(127, 107);
            AutoType_PasteClipboardCheckBox.Name = "AutoType_PasteClipboardCheckBox";
            AutoType_PasteClipboardCheckBox.Size = new Size(135, 24);
            AutoType_PasteClipboardCheckBox.TabIndex = 3;
            AutoType_PasteClipboardCheckBox.Text = "Paste Clipboard";
            AutoType_PasteClipboardCheckBox.UseVisualStyleBackColor = true;
            AutoType_PasteClipboardCheckBox.CheckedChanged += AutoType_PasteClipboardCheckBox_CheckedChanged;
            // 
            // AutoTypeUtilMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 215);
            Controls.Add(AutoType_PasteClipboardCheckBox);
            Controls.Add(AutoTypeUtil_SaveLabel);
            Controls.Add(AutoTypeUtil_SaveButton);
            Controls.Add(AutoType_DelayLabel);
            Controls.Add(AutoTypeUtil_DelayBox);
            Controls.Add(AutoType_TextBox);
            Controls.Add(AutoType_HideTextCheckBox);
            Controls.Add(AutoType_Button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AutoTypeUtilMain";
            Text = "AutoTypeUtil";
            FormClosing += MainWindow_OnClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AutoType_Button;
        private CheckBox AutoType_HideTextCheckBox;
        private TextBox AutoType_TextBox;
        private TextBox AutoTypeUtil_DelayBox;
        private Label AutoType_DelayLabel;
        private Button AutoTypeUtil_SaveButton;
        private Label AutoTypeUtil_SaveLabel;
        private CheckBox AutoType_PasteClipboardCheckBox;
    }
}
