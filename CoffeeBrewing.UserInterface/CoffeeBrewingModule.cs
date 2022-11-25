// <copyright file="CoffeeBrewingModule.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using CoffeeBrewing.Implementation;
using CoffeeBrewing.Implementation.BrewingSteps;
using Zeiss.Semi.Mask.Foundation.ApplicationFrame.Contracts.Regions;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts.Modularity;

namespace CoffeeBrewing.UserInterface;

public class CoffeeBrewingModule : ModuleBase
{
    public override Task<Result> RegisterTypesAsync(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<CoffeeBrewingView>();
        containerRegistry.Register<CoffeeBrewingViewModel>();

        containerRegistry.Register<IBrewingService, BrewingService>();
        containerRegistry.Register<BrewingSequenceBuilder>();

        containerRegistry.Register<HeatWaterStep>();
        containerRegistry.Register<GrindStep>();
        containerRegistry.Register<CleanStep>();
        
        return base.RegisterTypesAsync(containerRegistry);
    }

    public override Task<Result> InitializeAsync(IContainerProvider containerProvider)
    {
        var regionManager = containerProvider.Resolve<IRegionManager>();
        regionManager.RegisterViewWithRegion("MainRegion", typeof(CoffeeBrewingView));

        return base.InitializeAsync(containerProvider);
    }
}