using System.Windows.Input;
using CoffeeBrewing.UserInterface;
using Statistics.UserInterface;
using Zeiss.Semi.Mask.Foundation.ApplicationFrame.Contracts.Regions;
using Zeiss.Semi.Mask.Foundation.Common.UserInterface.Contracts.Mvvm;

namespace Starter
{
    public class MainViewModel
    {
        private readonly IRegionManager regionManager;
        private readonly INavigationRequestFactory requestFactory;

        public MainViewModel(IRegionManager regionManager, INavigationRequestFactory requestFactory)
        {
            this.requestFactory = requestFactory;
            this.regionManager = regionManager;

            this.BrewingCommand = new DelegateCommand(NavigateToBrewing);
            this.StatisticsCommand = new DelegateCommand(NavigateToStatistics);
        }

        public DelegateCommand StatisticsCommand { get; set; }

        private void NavigateToStatistics()
        {
            var request = requestFactory.Create(typeof(StatisticsView));
            this.regionManager.RequestNavigate("MainRegion", request);
        }

        public ICommand BrewingCommand { get; set; }

        private void NavigateToBrewing()
        {
            var request = requestFactory.Create(typeof(CoffeeBrewingView));
            this.regionManager.RequestNavigate("MainRegion", request);
        }
    }
}
