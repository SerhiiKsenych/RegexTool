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
    public class RegexViewModel : BindableBase
    {
        #region Fields and properties

        private static RegexViewModel _instance;
        private IRegexHelper _regexHelper;
        private RegexOptions _regexOptions;

        public static RegexViewModel Instance()
        {
            if (_instance == null)
                _instance = new RegexViewModel();
            return _instance;
        }

        private string _pattern;
        public string Pattern { get { return _pattern; } set { _pattern = value; OnPropertyChanged(nameof(Pattern)); } }

        private string _inputText;
        public string InputText { get { return _inputText; } set { _inputText = value; OnPropertyChanged(nameof(InputText)); } }

        private string _resultText;
        public string ResultText { get { return _resultText; } set { _resultText = value; OnPropertyChanged(nameof(ResultText)); } }

        private bool _isMultiline;
        public bool IsMultiline { get { return _isMultiline; } set { _isMultiline = value; OnPropertyChanged(nameof(IsMultiline)); } }

        private bool _isMultipleMatch;
        public bool IsMultipleMatch { get { return _isMultipleMatch; } set { _isMultipleMatch = value; OnPropertyChanged(nameof(IsMultipleMatch)); } }

        #endregion

        #region Commands

        public ICommand CommandRegexIt { get; set; }

        #endregion

        #region Ctor

        public RegexViewModel()
        {
            CommandRegexIt = new DelegateCommand(RegexIt);
            this.SetRegexHelper(new RegexHelper());
        }

        #endregion

        #region Private methods

        private void RegexIt()
        {
            if (_regexHelper == null)
                throw new Exception("RegexHelper is not initialized!");

            try
            {
                ResultText = _regexHelper.RegexIt(_inputText, _pattern, _isMultiline, _isMultipleMatch);
            }

            catch (Exception ex)
            {
                ResultText = ex.Message;
            }
        }

        #endregion

        #region Set dependencies

        public void SetRegexHelper(IRegexHelper regexHelper)
        {
            _regexHelper = regexHelper;
        }

        #endregion
    }
}
