using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WebClient;

namespace RegexTool.UI.ViewModel
{
    public class BrowserViewModel: BindableBase
    {
        private Client _client;
        private string _url;
        private string _webContent;

        public string Url
        {
            get { return _url; }
            set { _url = value;OnPropertyChanged(nameof(Url)); }
        }

        public ICommand CommandLoad { get; set; }

        public BrowserViewModel()
        {
            CommandLoad = new DelegateCommand(Load);
        }

        private void Load()
        {
            _client = new Client();
            _client.SendRequest(Url);
            _webContent=_client.GetTextResponce();
            RegexViewModel.Instance().InputText = _webContent;
        }
    }
}
