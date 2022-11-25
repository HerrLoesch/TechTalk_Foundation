// <copyright file="BrewingSequenceBuilder.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Implementation.BrewingSteps;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.SequenceEngine.Implementation.Contracts;
using Zeiss.Semi.Mask.Foundation.SequenceEngine.Implementation.Tools;

namespace CoffeeBrewing.Implementation;

public class BrewingSequenceBuilder : SequenceBuilder<CoffeeRecipe>
{
    public BrewingSequenceBuilder(IContainerProvider container) : base(container)
    {
    }

    public override void Build(IBuildSequence<CoffeeRecipe> sequence)
    {
        sequence.StartWith<GrindStep>()
            .Then<HeatWaterStep>()
            .Then<CleanStep>()
            .Exit();
    }
}