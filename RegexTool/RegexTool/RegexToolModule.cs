using Prism.Modularity;
using Prism.Regions;
using RegexTool.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTool
{
    public class RegexToolModule : IModule
    {
        private string _regionName = "RegexToolRegion";
        private IRegionManager _regionManager;
        public RegexToolModule(IRegionManager manager)
        {
            _regionManager = manager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(_regionName, typeof(RegexToolView));
        }
    }
}
