using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexWPF.Services
{
    internal interface IRegexService
    {
        string RegexIt(string inputText, string pattern, bool isMultiline, bool isMultipleMatch);
    }
}
