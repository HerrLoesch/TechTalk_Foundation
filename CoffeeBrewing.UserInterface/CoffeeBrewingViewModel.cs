using System.Windows.Input;
using CoffeeBrewing.Contracts;
using Zeiss.Semi.Mask.Foundation.Common.UserInterface.Contracts.Mvvm;

namespace CoffeeBrewing.UserInterface
{
    public class CoffeeBrewingViewModel : BindableBase
    {
        private readonly ICoffeeMachineRepository coffeeMachineRepository;
        private ICoffeeMachine coffeeMachine = null!;

        public CoffeeBrewingViewModel(ICoffeeMachineRepository coffeeMachineRepository)
        {
            this.coffeeMachineRepository = coffeeMachineRepository;
            this.BrewCommand = new DelegateCommand(this.Brew);
            this.InitializeCommand = new DelegateCommand(this.Initialize);
        }
        
        public void Initialize()
        {
            this.CoffeeMachine = coffeeMachineRepository.GetCoffeeMachine();
        }

        private void Brew()
        {
            
        }

        public ICoffeeMachine CoffeeMachine
        {
            get => coffeeMachine;
            private set => this.SetProperty(ref this.coffeeMachine, value);
        }

        public ICommand InitializeCommand { get; set; }
        public ICommand BrewCommand { get; set; }
    }
}
