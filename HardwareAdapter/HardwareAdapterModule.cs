// <copyright file="HardwareAdapterModule.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts.Modularity;

namespace HardwareAdapter;

public class HardwareAdapterModule : ModuleBase
{
    public override Task<Result> InitializeAsync(IContainerProvider containerProvider)
    {
        return base.InitializeAsync(containerProvider);
    }
}