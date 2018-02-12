using Prism.Modularity;
using Prism.Regions;
using RegexWPF.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexWPF
{
    public class RegexModule:IModule
    {
        public static string RegionName="RegexHostRegion";
        private IRegionManager _regionManager;
        public RegexModule(IRegionManager manager)
        {
            _regionManager = manager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionName, typeof(ShellView));
        }
    }
}
