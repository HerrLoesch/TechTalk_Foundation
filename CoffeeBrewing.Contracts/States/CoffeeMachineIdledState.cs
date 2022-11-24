// <copyright file="CoffeeMachineIdledState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class CoffeeMachineIdledState : CoffeeMachineOperationalState
{
    public CoffeeMachineIdledState() : base(false, "Idle")
    {
    }
}