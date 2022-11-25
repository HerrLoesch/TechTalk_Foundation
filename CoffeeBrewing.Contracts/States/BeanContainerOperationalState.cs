// <copyright file="BeanContainerOperationalState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public abstract class BeanContainerOperationalState : BeanContainerState
{
    protected BeanContainerOperationalState(bool isBusy, string displayName) : base(isBusy, displayName)
    {
    }
}