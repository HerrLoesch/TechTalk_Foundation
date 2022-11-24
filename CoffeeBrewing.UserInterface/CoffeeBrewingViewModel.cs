using Zeiss.Semi.Mask.Foundation.Common.UserInterface.Contracts.Mvvm;

namespace CoffeeBrewing.UserInterface
{
    public class CoffeeBrewingViewModel : BindableBase
    {
        public string Text { get; set; }

        public CoffeeBrewingViewModel()
        {
            Text = "Hallo Welt";
        }
    }
}
