// <copyright file="IGrinder.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts;

namespace CoffeeBrewing.Contracts;

public interface IGrinder : IComponent
{
    Task<Result> GrindAsync();

    Task<Result> StopGrindingAsync();
}