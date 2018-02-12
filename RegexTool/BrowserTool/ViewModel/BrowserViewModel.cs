using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Presentation.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserTool.ViewModel
{
    public class BrowserViewModel : BindableBase
    {
        private SubscriptionToken _token;
        private IEventAggregator _eventAggregator;

        private string _hello = "Hello from BrowserViewModel";
        public string Hello { get { return _hello; } set { _hello = value; RaisePropertyChanged(nameof(Hello)); } }

        public BrowserViewModel(IEventAggregator aggregator)
        {
            _eventAggregator = aggregator;
            _token=_eventAggregator.GetEvent<SimpleStringEvent>().Subscribe((msg)=>PrintMessage(msg));
        }

        private void PrintMessage(string message)
        {
            Hello = message;
        }
    }

    public class SimpleStringEvent : CompositePresentationEvent<string> { }
}
