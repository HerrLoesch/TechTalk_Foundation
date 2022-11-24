// <copyright file="CoffeeMachineUninitializedState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class CoffeeMachineUninitializedState : CoffeeMachineState
{
    public CoffeeMachineUninitializedState() : base(false, "Uninitialized")
    {
    }
}