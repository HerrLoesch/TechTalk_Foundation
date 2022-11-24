// <copyright file="CoffeeMachineBrewingState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class CoffeeMachineBrewingState : CoffeeMachineOperationalState
{
    public CoffeeMachineBrewingState() : base(true, "Brewing")
    {
    }
}