// <copyright file="HeaterHeatingState.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

namespace CoffeeBrewing.Contracts.States;

public class HeaterHeatingState : HeaterState
{
    public HeaterHeatingState() : base(true, "Heating")
    {
    }
}