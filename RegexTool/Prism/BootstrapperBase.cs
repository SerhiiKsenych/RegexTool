using CommonServiceLocator;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using Unity;

namespace Prism
{
    internal class BootstrapperBase
    {
        protected DependencyObject Shell;
        protected IUnityContainer Container;
        protected IModuleCatalog ModuleCatalog;

        protected virtual DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected virtual void InitializeShell()
        {
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected virtual IUnityContainer CreateContainer()
        {
            return new UnityContainer();
        }

        protected virtual void ConfigureContainer() { }

        protected virtual IModuleCatalog CreateModuleCatalog()
        {
            return new ModuleCatalog();
        }

        protected virtual void ConfigureModuleCatalog()
        {

        }


        public void Run()
        {
            this.Shell=this.CreateShell();
            this.InitializeShell();
            this.Container = this.CreateContainer();
            this.ConfigureContainer();
            this.ModuleCatalog = this.CreateModuleCatalog();
        }

    }
}