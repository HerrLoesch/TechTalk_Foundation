// <copyright file="HardwareAdapterModule.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts.Modularity;

namespace HardwareAdapter;

public class HardwareAdapterModule : ModuleBase
{
    public override Task<Result> RegisterTypesAsync(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<ICoffeeMachineRepository, CoffeeMachineRepository>();

        return base.RegisterTypesAsync(containerRegistry);
    }
}