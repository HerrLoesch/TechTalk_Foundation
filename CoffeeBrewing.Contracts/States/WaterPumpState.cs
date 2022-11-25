// <copyright file="WaterPumpState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace CoffeeBrewing.Contracts.States;

public abstract class WaterPumpState : ActuatorState
{
    protected WaterPumpState(bool isBusy, string displayName) : base(isBusy, displayName)
    {
    }
}