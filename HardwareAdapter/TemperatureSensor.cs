// <copyright file="TemperatureSensor.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using UnitsNet;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Sensors;

namespace HardwareAdapter;

internal class TemperatureSensor : Sensor<Temperature>
{
    public TemperatureSensor( string name, IComponent origin) : base(Temperature.FromDegreesCelsius(20), "", name, origin)
    {
    }

    public void SetTemperature(Temperature temperature)
    {
        UpdateValue(temperature);
    }

    public void RemoveTemperature(Temperature temperatureToRemove)
    {
        var newTemperature = this.LastValidValue.DegreesCelsius - temperatureToRemove.DegreesCelsius;
        SetTemperature(Temperature.FromDegreesCelsius(newTemperature));
    }

    public void AddTemperature(Temperature temperatureToAdd)
    {
        var newTemperature = this.LastValidValue.DegreesCelsius + temperatureToAdd.DegreesCelsius;
        SetTemperature(Temperature.FromDegreesCelsius(newTemperature));
    }
}