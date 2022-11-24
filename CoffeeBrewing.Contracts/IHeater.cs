// <copyright file="IHeater.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts.States;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Sensors;

namespace CoffeeBrewing.Contracts;

public interface IHeater : IActuator<HeaterState>
{
    Task<Result> StartHeatingAsync(Temperature targetTemperature);
    Task<Result> StopHeatingAsync();

    ISensor<Temperature> CurrentTemperature { get; }
}