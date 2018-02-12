using Prism.Unity;
using System.Windows;
using Prism.Modularity;
using System;
using Microsoft.Practices.Unity;
using Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Main.Views;
using RegexWPF;

namespace Main
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new ShellView();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            (ModuleCatalog as ConfigurationModuleCatalog).AddModule(typeof(RegexModule));
        }
    }
}
