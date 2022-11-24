// <copyright file="CoffeeMachineCleaningState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class CoffeeMachineCleaningState : CoffeeMachineOperationalState
{
    public CoffeeMachineCleaningState() : base(true, "Cleaning")
    {
    }
}