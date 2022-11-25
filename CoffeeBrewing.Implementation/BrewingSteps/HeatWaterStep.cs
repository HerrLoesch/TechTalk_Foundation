// <copyright file="HeatWater.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.SequenceEngine.Implementation.Contracts;

namespace CoffeeBrewing.Implementation.BrewingSteps;

public class HeatWaterStep : ISequenceStep<CoffeeRecipe>
{
    private ICoffeeMachineRepository coffeeMachineRepository;

    public HeatWaterStep(ICoffeeMachineRepository coffeeMachineRepository)
    {
        this.coffeeMachineRepository = coffeeMachineRepository;
    }

    public async Task<Result> RunAsync(CoffeeRecipe data)
    {
        var coffeeMachine = this.coffeeMachineRepository.GetCoffeeMachine();

        var startResult = await coffeeMachine.Heater.StartHeatingAsync(Temperature.FromDegreesCelsius(80));

        if (startResult.Failed)
        {
            return startResult;
        }

        var waterResult = await coffeeMachine.WaterPump.PumpAsync(data.AmountOfWater);

        var heatingResult = await coffeeMachine.Heater.StopHeatingAsync();

        var overAllFailures = waterResult.Failures.Concat(heatingResult.Failures);
        return Result.CreateFrom(overAllFailures);
    }
}