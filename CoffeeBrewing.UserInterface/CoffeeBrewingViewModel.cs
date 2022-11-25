using System.Windows.Input;
using CoffeeBrewing.Contracts;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.UserInterface.Contracts.Mvvm;

namespace CoffeeBrewing.UserInterface
{
    public class CoffeeBrewingViewModel : BindableBase
    {
        private readonly ICoffeeMachineRepository coffeeMachineRepository;
        private ICoffeeMachine? coffeeMachine;
        private IBrewingService brewingService;

        public CoffeeBrewingViewModel(ICoffeeMachineRepository coffeeMachineRepository, IBrewingService brewingService)
        {
            this.brewingService = brewingService;
            this.coffeeMachineRepository = coffeeMachineRepository;
            this.BrewCommand = new AsyncDelegateCommand(this.Brew);
            this.InitializeCommand = new DelegateCommand(this.Initialize);
        }

        public void Initialize()
        {
            this.CoffeeMachine = coffeeMachineRepository.GetCoffeeMachine();
        }

        private async Task Brew()
        {
            // EVIL!!!
            var result = await this.brewingService.Brew(Mass.FromGrams(15), Volume.FromMilliliters(60));

            if (result is Error)
            {
                this.Failures = result.Failures;
            }
        }

        public IEnumerable<Failure> Failures { get; set; }

        public ICoffeeMachine? CoffeeMachine
        {
            get => coffeeMachine;
            private set => this.SetProperty(ref this.coffeeMachine, value);
        }

        public ICommand InitializeCommand { get; set; }
        public ICommand BrewCommand { get; set; }
    }
}
