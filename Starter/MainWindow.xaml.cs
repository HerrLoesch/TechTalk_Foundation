using System.Windows;
using Zeiss.Semi.Mask.Foundation.ApplicationFrame.Contracts.Regions;

namespace Starter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();
        }
    }
}
