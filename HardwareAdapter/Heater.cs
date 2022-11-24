// <copyright file="Heater.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;
using CoffeeBrewing.Contracts;
using CoffeeBrewing.Contracts.States;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Sensors;

namespace HardwareAdapter;

public class Heater : Actuator<HeaterState>, IHeater
{
    private readonly TemperatureSensor sensor;
    private CancellationTokenSource? cancellationTokenSource;

    public Heater() : base(new HeaterIdleState(), "Heater")
    {
        this.sensor = new TemperatureSensor("Heater Temperature Sensor", this);
    }

    public ISensor<Temperature> CurrentTemperature => this.sensor;

    public async Task<Result> StartHeatingAsync(Temperature targetTemperature)
    {
        if (this.State is HeaterHeatingState)
        {
            return Result.Failure(new Failure("Heater is already heating!"));
        }

        CancelTimerAndReset();

        this.State = new HeaterHeatingState();
        await GoToTargetTemperatureAsync(targetTemperature, this.cancellationTokenSource.Token);

        return Result.Success();
    }

    public async Task<Result> StopHeatingAsync()
    {
        CancelTimerAndReset();

        _ = GoToTargetTemperatureAsync(Temperature.FromDegreesCelsius(20), this.cancellationTokenSource.Token);

        this.State = new HeaterIdleState();

        return await Task.FromResult(Result.Success());
    }

    [MemberNotNull(nameof(cancellationTokenSource))]
    private void CancelTimerAndReset()
    {
        this.cancellationTokenSource?.Cancel();
        this.cancellationTokenSource = new CancellationTokenSource();
    }

    private async Task GoToTargetTemperatureAsync(Temperature targetTemperature, CancellationToken token)
    {
        while (this.CurrentTemperature.LastValidValue.Value != targetTemperature.Value)
        {
            // defines if we have to increase or decrease the temperature
            var factor = targetTemperature > this.CurrentTemperature.LastValidValue ? 1 : -1;

            var newTemperature = this.CurrentTemperature.LastValidValue.DegreesCelsius + 5 * factor;
            this.sensor.SetTemperature(Temperature.FromDegreesCelsius(newTemperature));

            try
            {
                // in case the task is canceled
                await Task.Delay(TimeSpan.FromMilliseconds(250), token);
            }
            catch (TaskCanceledException)
            {
                break;
            }
        }
    }
}