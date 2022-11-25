// <copyright file="GrindStep.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.SequenceEngine.Implementation.Contracts;

namespace CoffeeBrewing.Implementation.BrewingSteps;

public class GrindStep : ISequenceStep<CoffeeRecipe>
{
    private readonly ICoffeeMachineRepository coffeeMachineRepository;

    public GrindStep(ICoffeeMachineRepository coffeeMachineRepository)
    {
        this.coffeeMachineRepository = coffeeMachineRepository;
    }

    public async Task<Result> RunAsync(CoffeeRecipe data)
    {
        var coffeeMachine = coffeeMachineRepository.GetCoffeeMachine();
        
        var grindResult = await coffeeMachine.Grinder.GrindAsync();

        Result? beanResult = null;

        if (grindResult is Success)
        {
            beanResult = await coffeeMachine.BeanContainer.ReleaseAsync(data.AmountOfBeans);
        }

        // We stop always
        var stopResult = await coffeeMachine.Grinder.StopGrindingAsync();

        var overAllFailures = grindResult.Failures.Concat(stopResult.Failures).Concat(beanResult?.Failures);

        return Result.CreateFrom(overAllFailures);
    }
}