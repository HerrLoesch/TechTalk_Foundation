// <copyright file="GrinderState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace CoffeeBrewing.Contracts.States;

public abstract class GrinderState : ActuatorState
{
    protected GrinderState(bool isBusy, string displayName) : base(isBusy, displayName)
    {
    }
}