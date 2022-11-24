// <copyright file="IWaterPump.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts;

namespace CoffeeBrewing.Contracts;

public interface IWaterPump : IComponent
{
    Task<Result> PumpAsync(Volume volume);
}