// <copyright file="BeanContainerUninitializedState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class BeanContainerUninitializedState : BeanContainerState
{
    public BeanContainerUninitializedState() : base(false, "Uninitialized")
    {
    }
}