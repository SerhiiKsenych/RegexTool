using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexer
{
    public class RegexHelper : IRegexHelper
    {
        public string RegexIt(string inputText, string pattern, RegexOptions options, bool isMultipleMatch)
        {
            string result = String.Empty;

            if (isMultipleMatch)
            {
                var matches = Regex.Matches(inputText, pattern, options);
                foreach (var m in matches)
                {
                    result += String.Format("{0}\n", m.ToString());
                }
            }
            else
            {
                var match = Regex.Match(inputText, pattern, options);
                result = match.ToString();
            }

            return result;
        }
    }
}
