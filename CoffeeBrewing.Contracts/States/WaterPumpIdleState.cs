// <copyright file="WaterPumpIdleState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class WaterPumpIdleState : WaterPumpState
{
    public WaterPumpIdleState() : base(false, "Idle")
    {
    }
}