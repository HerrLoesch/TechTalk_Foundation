// <copyright file="BeanContainerReleasingState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class BeanContainerReleasingState : BeanContainerOperationalState
{
    public BeanContainerReleasingState() : base(true, "Releasing")
    {
    }
}