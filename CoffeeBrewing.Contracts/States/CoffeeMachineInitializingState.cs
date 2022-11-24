// <copyright file="CoffeeMachineInitializingState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class CoffeeMachineInitializingState : CoffeeMachineState
{
    public CoffeeMachineInitializingState() : base(true, "Initializing")
    {
    }
}