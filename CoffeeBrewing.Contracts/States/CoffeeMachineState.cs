// <copyright file="CoffeeMachineState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace CoffeeBrewing.Contracts.States;

public class CoffeeMachineState : ActuatorState
{
    public CoffeeMachineState(bool isBusy, string displayName) : base(isBusy, displayName)
    {
    }
}