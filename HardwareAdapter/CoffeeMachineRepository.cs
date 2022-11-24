// <copyright file="CoffeeMachineRepository.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;

namespace HardwareAdapter;

public class CoffeeMachineRepository : ICoffeeMachineRepository
{
    private ICoffeeMachine? machine;

    public ICoffeeMachine GetCoffeeMachine()
    {
        if (machine == null)
        {
            this.machine = new CoffeeMachine(new BeanContainer(), new WaterPump(), new Grinder(), new Heater());
        }

        return this.machine;
    }
}