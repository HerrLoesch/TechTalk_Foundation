// <copyright file="WaterPumpPumpingState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class WaterPumpPumpingState : WaterPumpState
{
    public WaterPumpPumpingState() : base(true, "Pumping")
    {
    }
}