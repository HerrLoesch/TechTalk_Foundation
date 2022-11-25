// <copyright file="IWaterPump.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts.States;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace CoffeeBrewing.Contracts;

public interface IWaterPump : IActuator<WaterPumpState>
{
    Task<Result> PumpAsync(Volume volume);
}