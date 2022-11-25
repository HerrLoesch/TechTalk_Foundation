// <copyright file="CoffeeMachineRepository.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.Events;

namespace HardwareAdapter;

public class CoffeeMachineRepository : ICoffeeMachineRepository
{
    private ICoffeeMachine? machine;
    private readonly IEventSubscriber subscriber;

    public CoffeeMachineRepository(IEventSubscriber subscriber)
    {
        this.subscriber = subscriber;
    }

    public ICoffeeMachine GetCoffeeMachine()
    {
        if (machine == null)
        {
            this.machine = new CoffeeMachine(this.subscriber, new BeanContainer(), new WaterPump(), new Grinder(), new Heater());
        }

        return this.machine;
    }
}