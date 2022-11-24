// <copyright file="IBeanContainer.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts;

namespace CoffeeBrewing.Contracts;

public interface IBeanContainer : IComponent
{
    Task<Result> ReleaseAsync(Mass mass);
}