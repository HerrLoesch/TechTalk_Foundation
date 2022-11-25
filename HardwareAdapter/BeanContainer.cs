// <copyright file="BeanContainer.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using CoffeeBrewing.Contracts.States;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace HardwareAdapter;

public class BeanContainer : Actuator<BeanContainerState>, IBeanContainer
{
    public async Task<Result> ReleaseAsync(Mass mass)
    {
        this.State = new BeanContainerReleasingState();
        
        await Task.Delay(TimeSpan.FromSeconds(2));

        this.State = new BeanContainerIdleState();

        return Result.Success();
    }

    public BeanContainer() : base(new BeanContainerIdleState(), "Bean Container")
    {
    }
}