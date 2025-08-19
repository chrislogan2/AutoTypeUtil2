using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutoTypeUtil2
{
    internal class Util
    {
        // SentText Hack:https://stackoverflow.com/questions/18299216/send-special-character-with-sendkeys
        // made marginally cleaner with .Contains
        static String regexSendKeysPattern = "[+^%~(){}]";
        static String regexSendKeysOutput = "{$0}";
        internal static void SendTextSpecialChars(string blockText)
        {
            string txt = Regex.Replace(blockText, regexSendKeysPattern, regexSendKeysOutput);
            SendKeys.Send(txt);
        }
        internal static async void FadeInLabel(System.Windows.Forms.Label o, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            o.Show();
            o.ForeColor = System.Drawing.Color.White;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.WhiteSmoke;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.Gray;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.DarkGray;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.Black;
            await Task.Delay(interval);

        }

        internal static async void FadeOutLabel(System.Windows.Forms.Label o, int interval = 80)
        {
            //Object is fully visible. Fade it out

            o.ForeColor = System.Drawing.Color.Black;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.DarkGray;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.Gray;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.WhiteSmoke;
            await Task.Delay(interval);
            o.ForeColor = System.Drawing.Color.White;
            await Task.Delay(interval);

            o.Hide();


        }
    }
}
