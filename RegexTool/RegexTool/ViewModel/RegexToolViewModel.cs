using Microsoft.Practices.Composite.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTool.ViewModel
{
    public class RegexToolViewModel : BindableBase
    {
        private IEventAggregator _eventAggregator;
        private string _hello = "Hello from RegexToolViewModel!";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(nameof(Hello)); }
        }

        public RegexToolViewModel(IEventAggregator agregator)
        {
            _eventAggregator = agregator;
        }
    }
}
