// <copyright file="App.xaml.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using System.Windows;
using Zeiss.Semi.Mask.Foundation.ApplicationFrame.Implementation;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.Logging;

namespace Starter
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : ApplicationBase
    {
        protected override BaseLogger CreateBaseLogger()
        {
            return new Logger();
        }

        protected override Window CreateSplashScreenWindow(IContainerProvider containerProvider)
        {
            return new SplashScreen();
        }

        protected override Result<Window> CreateShell(IContainerProvider containerProvider)
        {
            var mainWindow = containerProvider.Resolve<MainWindow>();
            return Result.Success((Window)mainWindow);
        }

        protected override ApplicationStartupBase CreateStartup()
        {
            return new Bootstrapper(this);
        }
    }
}