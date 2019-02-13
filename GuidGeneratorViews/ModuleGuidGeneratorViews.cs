using GuidGeneratorViews.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace GuidGeneratorViews
{
    public class ModuleGuidGeneratorViews : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(GenerateGuidView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
