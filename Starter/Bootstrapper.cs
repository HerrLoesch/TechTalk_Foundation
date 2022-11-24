// <copyright file="Bootstrapper.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using Zeiss.Semi.Mask.Foundation.ApplicationFrame.Implementation;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.IoC;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.Logging;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts;
using Zeiss.Semi.Mask.Foundation.Frame.Contracts.Bootstrapping;

namespace Starter;

public class Bootstrapper : ApplicationStartupBase
{
    private IApplication application;

    public Bootstrapper(IApplication application)
    {
        this.application = application;
    }

    public override Result RegisterTypes(IContainerRegistry containerRegistry)
    {
        return Result.Success();
    }

    public override Result Configure(IApplicationBootstrapperBuilder applicationBootstrapperBuilder, ILoggerFactory loggerFactory)
    {
        applicationBootstrapperBuilder.AddApplication(this.application)
            .AddRegionSetup(new RegionSetup())
            .AddModuleSetup(new CustomModuleSetup(loggerFactory))
            .ConfigureContainer(option => option.RunContainerSanityChecks = true);
 
        return Result.Success();
    }
}