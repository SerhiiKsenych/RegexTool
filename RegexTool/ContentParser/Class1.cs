using RegexTool.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentParser
{
    public class Class1
    {
        private IRegexHelper _regexHelper;
        public Class1(IRegexHelper regexHelper)
        {
            _regexHelper = regexHelper;
        }
    }
}
