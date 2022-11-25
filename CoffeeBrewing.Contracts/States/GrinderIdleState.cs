// <copyright file="GrinderIdleState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class GrinderIdleState : GrinderState
{
    public GrinderIdleState() : base(false, "Idle")
    {
    }
}