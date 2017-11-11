using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTool.Core
{
    public interface IRegexHelper
    {
        string RegexIt(string inputText, string pattern, RegexOptions options, bool isMultipleMatch);
    }
}
