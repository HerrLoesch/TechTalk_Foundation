using UnitsNet;

namespace CoffeeBrewing.Implementation.BrewingSteps;

public class CoffeeRecipe
{
    public CoffeeRecipe(Mass amountOfBeans, Volume amountOfWater)
    {
        AmountOfBeans = amountOfBeans;
        AmountOfWater = amountOfWater;
    }

    public Mass AmountOfBeans { get; }
    public Volume AmountOfWater { get; }
}