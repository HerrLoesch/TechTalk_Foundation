// <copyright file="CoffeeMachine.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using CoffeeBrewing.Contracts.States;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace HardwareAdapter;

public class CoffeeMachine : Actuator<CoffeeMachineState>, ICoffeeMachine
{
    public IBeanContainer BeanContainer { get; }
    
    public IWaterPump WaterPump { get; }
    
    public IGrinder Grinder { get; }
    
    public IHeater Heater { get; }

    public CoffeeMachine(IBeanContainer beanContainer, IWaterPump waterPump, IGrinder grinder, IHeater heater) : base(new CoffeeMachineUninitializedState(), "Coffee Machine")
    {
        BeanContainer = beanContainer;
        WaterPump = waterPump;
        Grinder = grinder;
        Heater = heater;
    }
}