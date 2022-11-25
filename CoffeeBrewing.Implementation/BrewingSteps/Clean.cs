// <copyright file="Clean.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.SequenceEngine.Implementation.Contracts;

namespace CoffeeBrewing.Implementation.BrewingSteps;

public class Clean : ISequenceStep<CoffeeRecipe>
{
    private ICoffeeMachineRepository coffeeMachineRepository;

    public Clean(ICoffeeMachineRepository coffeeMachineRepository)
    {
        this.coffeeMachineRepository = coffeeMachineRepository;
    }

    public Task<Result> RunAsync(CoffeeRecipe data)
    {
        var coffeeMachine = this.coffeeMachineRepository.GetCoffeeMachine();

        return coffeeMachine.WaterPump.PumpAsync(Volume.FromMilliliters(250));
    }
}