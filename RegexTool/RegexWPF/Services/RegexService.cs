using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexWPF.Services
{
    internal class RegexService : IRegexService
    {
        public string RegexIt(string inputText, string pattern, bool isMultiline, bool isMultipleMatch)
        {
            string result = String.Empty;

            RegexOptions options = new RegexOptions();
            if (isMultiline)
                options = RegexOptions.Singleline;

            else
                options = RegexOptions.None;


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
