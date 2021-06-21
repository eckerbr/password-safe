using EckTech.PasswordSafe.Core;
using EckTech.PasswordSafe.Modules.PasswordsGrid.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace EckTech.PasswordSafe.Modules.PasswordsGrid
{
    public class PasswordsGridModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public PasswordsGridModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}