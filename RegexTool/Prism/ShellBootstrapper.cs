using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Logging;
using RegexTool.Core;
using Unity;
using WebClient;
using RegexTool.UI.ViewModel;
using Prism.Modularity;

namespace Prism
{
    internal class ShellBootstrapper : BootstrapperBase
    {
        protected override void ConfigureContainer()
        {
            this.Container.RegisterType<IRegexHelper, RegexHelper>();
            this.Container.RegisterType<Client>();
            this.Container.RegisterInstance<RegexViewModel>(new RegexViewModel());
            this.Container.RegisterInstance<BrowserViewModel>(new BrowserViewModel());
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleInfo moduleInfo = new ModuleInfo("BrowserToolModule", "BrowserToolModule");
            this.ModuleCatalog.AddModule(moduleInfo);
        }
    }
}
