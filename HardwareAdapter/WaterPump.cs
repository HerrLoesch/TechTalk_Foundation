// <copyright file="WaterPump.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using CoffeeBrewing.Contracts.States;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace HardwareAdapter;

public class WaterPump : Actuator<WaterPumpState>, IWaterPump
{
    public WaterPump() : base(new WaterPumpIdleState(), "Water Pump")
    {
    }

    public async Task<Result> PumpAsync(Volume volume)
    {
        await Task.Delay(TimeSpan.FromSeconds(4));

        return Result.Success();
    }
}