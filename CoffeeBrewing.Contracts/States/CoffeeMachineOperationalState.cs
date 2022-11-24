// <copyright file="CoffeeMachineOperationalState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class CoffeeMachineOperationalState : CoffeeMachineState
{
    public CoffeeMachineOperationalState(bool isBusy, string displayName) : base(isBusy, displayName)
    {
    }
}