using System.Text.RegularExpressions;

namespace Regexer
{
    public interface IRegexHelper
    {
        string RegexIt(string inputText, string pattern, RegexOptions options, bool isMultipleMatch);
    }
}