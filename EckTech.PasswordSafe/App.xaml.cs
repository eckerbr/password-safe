using EckTech.PasswordSafe.Core.Common.Types;
using EckTech.PasswordSafe.Modules.PasswordsGrid;
using EckTech.PasswordSafe.Services;
using EckTech.PasswordSafe.Services.Interfaces;
using EckTech.PasswordSafe.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace EckTech.PasswordSafe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ISafeService, SafeService>();
            containerRegistry.RegisterSingleton<Session>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PasswordsGridModule>();
        }
    }
}
