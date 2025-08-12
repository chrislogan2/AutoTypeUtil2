using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTypeUtil2
{
    internal class Util
    {
        // SentText Hack: https://stackoverflow.com/questions/18291756/send-keys-special-characters-c-sharp
        // made marginally cleaner with .Contains
        static char[] specialChars = { '{', '}', '(', ')', '+', '^' };
        internal static void SendTextSpecialChars(string blockText)
        {
            foreach (char letter in blockText)
            {
                bool _specialCharFound = false;
                _specialCharFound=specialChars.Contains(letter) ? true : false;

                if (_specialCharFound)
                    SendKeys.Send("{" + letter.ToString() + "}");
                else
                    SendKeys.Send(letter.ToString());
            }
        }
    }
}
