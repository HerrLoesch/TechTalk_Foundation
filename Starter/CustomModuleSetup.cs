// <copyright file="CustomModuleSetuö.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.UserInterface;
using HardwareAdapter;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.Logging;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts.Modularity;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts.Modularity.Config;

namespace Starter;

internal sealed class CustomModuleSetup : ModuleSetup
{
    public CustomModuleSetup(ILoggerFactory loggerFactory) : base(loggerFactory)
    {
    }

    protected override Result<IModuleCatalog> CreateModuleCatalog(IAssemblyProvider assemblyProvider)
    {
        var moduleCatalog = new ModuleCatalog();

        var brewingModule = ModuleInfo.CreateFromType<CoffeeBrewingModule>();
        moduleCatalog.AddModule(brewingModule);

        var hardwareModule = ModuleInfo.CreateFromType<HardwareAdapterModule>();
        moduleCatalog.AddModule(hardwareModule);

        return Result.Success((IModuleCatalog)moduleCatalog);
    }
}