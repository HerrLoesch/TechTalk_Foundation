// <copyright file="GrinderGrindingState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class GrinderGrindingState : GrinderState
{
    public GrinderGrindingState() : base(false, "Grinding")
    {
    }
}