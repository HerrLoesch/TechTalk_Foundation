// <copyright file="WaterPump.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;

namespace HardwareAdapter;

public class WaterPump : IWaterPump
{
    public string Id { get; }
    public string Name { get; }

    public WaterPump()
    {
        Id = "15";
        Name = "Water Pump";
    }

    public async Task<Result> PumpAsync(Volume volume)
    {
        await Task.Delay(TimeSpan.FromSeconds(4));
        
        return Result.Success();
    }
}