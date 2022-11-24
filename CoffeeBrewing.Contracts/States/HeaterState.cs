// <copyright file="HeaterState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace CoffeeBrewing.Contracts.States;

public abstract class HeaterState : ActuatorState
{
    protected HeaterState(bool isBusy, string displayName) : base(isBusy, displayName)
    {
    }
}