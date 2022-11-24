// <copyright file="HeaterIdleState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class HeaterIdleState : HeaterState
{
    public HeaterIdleState() : base(false, "Idle")
    {
    }
}