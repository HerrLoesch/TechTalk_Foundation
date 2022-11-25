// <copyright file="BrewingService.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using CoffeeBrewing.Contracts.Events;
using CoffeeBrewing.Implementation.BrewingSteps;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.Events;
using Zeiss.Semi.Mask.Foundation.SequenceEngine.Implementation;

namespace CoffeeBrewing.Implementation;

public class BrewingService : IBrewingService
{
    private readonly BrewingSequenceBuilder sequenceBuilder;
    private IEventPublisher eventPublisher;

    public BrewingService(BrewingSequenceBuilder sequenceBuilder, IEventPublisher eventPublisher)
    {
        this.eventPublisher = eventPublisher;
        this.sequenceBuilder = sequenceBuilder;
    }

    public async Task<Result> Brew(Mass coffee, Volume water)
    {
        var sequence = new Sequence<CoffeeRecipe>(this.sequenceBuilder);

        this.eventPublisher.Publish(new BrewingEvent());

        var result = await sequence.RunAsync(new CoffeeRecipe(coffee, water));

        this.eventPublisher.Publish(new CoffeeFinishedEvent());

        return result;
    }
}