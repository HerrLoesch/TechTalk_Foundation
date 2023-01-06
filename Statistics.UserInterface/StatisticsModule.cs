// <copyright file="CoffeeBrewingModule.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.ApplicationFrame.Contracts.Regions;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.Common.UserInterface.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts.Modularity;

namespace Statistics.UserInterface;

public class StatisticsModule : ModuleBase
{
    public override Task<Result> RegisterTypesAsync(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<StatisticsView, StatisticsViewModel>();
        
        return base.RegisterTypesAsync(containerRegistry);
    }

    public override Task<Result> InitializeAsync(IContainerProvider containerProvider)
    {
        var regionManager = containerProvider.Resolve<IRegionManager>();
        regionManager.RegisterViewWithRegion("MainRegion", typeof(StatisticsView));

        return base.InitializeAsync(containerProvider);
    }
}

