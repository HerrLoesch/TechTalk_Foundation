// <copyright file="ICoffeeMachine.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts.States;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace CoffeeBrewing.Contracts;

public interface ICoffeeMachine : IActuator<CoffeeMachineState>
{
    IBeanContainer BeanContainer { get; }

    IWaterPump WaterPump { get; }

    IGrinder Grinder { get; }

    IHeater Heater { get; }
}