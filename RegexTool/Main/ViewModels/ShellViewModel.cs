using Prism.Mvvm;
using RegexWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ViewModels
{
    public class ShellViewModel:BindableBase
    {
        
        public string HostRegion
        {
            get => _hostRegion;
            set
            {
                _hostRegion = value;
                RaisePropertyChanged(nameof(HostRegion));
            }
        }
        private string _hostRegion;
        public ShellViewModel()
        {
            HostRegion = RegexModule.RegionName;
        }
    }
}
