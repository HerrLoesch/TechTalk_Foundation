using Zeiss.Semi.Mask.Foundation.Common.UserInterface.Contracts.Mvvm;

namespace Statistics.UserInterface
{
    public class StatisticsViewModel : BindableBase
    {
        public StatisticsViewModel()
        {
            this.InitializeCommand = new DelegateCommand(Initialize);
        }

        public DelegateCommand InitializeCommand { get; set; }

        private void Initialize()
        {

        }
    }
}
