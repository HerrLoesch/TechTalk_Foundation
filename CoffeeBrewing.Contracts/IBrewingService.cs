// <copyright file="IBrewingService.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;

namespace CoffeeBrewing.Contracts;

public interface IBrewingService
{
    Task<Result> Brew(Mass coffee, Volume water);
}