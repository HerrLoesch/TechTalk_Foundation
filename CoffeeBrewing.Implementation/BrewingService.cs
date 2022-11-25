// <copyright file="BrewingService.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using CoffeeBrewing.Implementation.BrewingSteps;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.SequenceEngine.Implementation;

namespace CoffeeBrewing.Implementation;

public class BrewingService : IBrewingService
{
    private readonly BrewingSequenceBuilder sequenceBuilder;

    public BrewingService(BrewingSequenceBuilder sequenceBuilder)
    {
        this.sequenceBuilder = sequenceBuilder;
    }

    public Task<Result> Brew(Mass coffee, Volume water)
    {
        var sequence = new Sequence<CoffeeRecipe>(this.sequenceBuilder);
        return sequence.RunAsync(new CoffeeRecipe(coffee, water));
    }
}