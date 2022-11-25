// <copyright file="BeanContainerIdleState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class BeanContainerIdleState : BeanContainerOperationalState
{
    public BeanContainerIdleState() : base(false, "Idle")
    {
    }
}