using Prism.Commands;
using Prism.Mvvm;
using RegexWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RegexWPF.UI.ViewModels
{
    public class ShellViewModel:BindableBase
    {
        #region Fields and properties

        private IRegexService _regexService;
        private RegexOptions _regexOptions;

        private string _pattern;
        public string Pattern { get { return _pattern; } set { _pattern = value; RaisePropertyChanged(nameof(Pattern)); } }

        private string _inputText;
        public string InputText { get { return _inputText; } set { _inputText = value; RaisePropertyChanged(nameof(InputText)); } }

        private string _resultText;
        public string ResultText { get { return _resultText; } set { _resultText = value; RaisePropertyChanged(nameof(ResultText)); } }

        private bool _isMultiline;
        public bool IsMultiline { get { return _isMultiline; } set { _isMultiline = value; RaisePropertyChanged(nameof(IsMultiline)); } }

        private bool _isMultipleMatch;
        public bool IsMultipleMatch { get { return _isMultipleMatch; } set { _isMultipleMatch = value; RaisePropertyChanged(nameof(IsMultipleMatch)); } }

        #endregion

        #region Commands

        public ICommand CommandRegexIt { get; set; }

        #endregion

        #region Ctor

        public ShellViewModel()
        {
            CommandRegexIt = new DelegateCommand(RegexIt);
            SetRegexServiceDependency(new RegexService());
        }

        #endregion

        #region Private methods

        private void RegexIt()
        {
            if (_regexService == null)
                throw new Exception("RegexService is not initialized!");

            try
            {
                Task task = Task.Run(()=> 
                {
                    ResultText = _regexService.RegexIt(_inputText, _pattern, _isMultiline, _isMultipleMatch);
                });                  
            }

            catch (Exception ex)
            {
                ResultText = ex.Message;
            }
        }

        #endregion

        #region Set dependencies

        internal void SetRegexServiceDependency(IRegexService regexHelper)
        {
            _regexService = regexHelper;
        }

        #endregion
    }
}
