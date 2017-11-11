using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using RegexTool.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegexTool.UI.ViewModel
{
    public class ShellViewModel : BindableBase
    {
        private IRegexHelper _regexHelper;
        private RegexOptions _regexOptions;
        private string _expression;
        public string Expression { get { return _expression; } set { _expression = value; OnPropertyChanged(nameof(Expression)); } }

        private string _inputText;
        public string InputText { get { return _inputText; } set { _inputText = value; OnPropertyChanged(nameof(InputText)); } }

        private string _resultText;
        public string ResultText { get { return _resultText; } set { _resultText = value; OnPropertyChanged(nameof(ResultText)); } }

        private bool _isMultiline;
        public bool IsMultiline { get { return _isMultiline; } set { _isMultiline = value; OnPropertyChanged(nameof(IsMultiline)); } }

        private bool _isMultipleMatch;
        public bool IsMultipleMatch { get { return _isMultipleMatch; } set { _isMultipleMatch = value; OnPropertyChanged(nameof(IsMultipleMatch)); } }



        public ICommand CommandRegexIt { get; set; }

        public ShellViewModel()
        {
            CommandRegexIt = new DelegateCommand(RegexIt);
        }

        private void RegexIt()
        {
            _regexHelper = new RegexHelper();

            if (_isMultiline)
                _regexOptions = RegexOptions.Singleline;
            else
                _regexOptions = RegexOptions.None;

            if (_regexHelper == null)
                throw new Exception("RegexHelper is not initialized!");

            try
            {
                ResultText = _regexHelper.RegexIt(_inputText, _expression, _regexOptions, _isMultipleMatch);
            }

            catch (Exception ex)
            {
                ResultText = ex.Message;
            }
        }
    }
}
