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
        static String regexSendKeysPattern = "[+^%~()]";
        static String regexSendKeysOutput = "{$0}";
        internal static void SendTextSpecialChars(string blockText)
        {
            string txt = Regex.Replace(blockText, regexSendKeysPattern, regexSendKeysOutput);
            SendKeys.Send(txt);
        }
    }
}
