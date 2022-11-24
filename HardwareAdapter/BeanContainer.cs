// <copyright file="BeanContainer.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using UnitsNet;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;

namespace HardwareAdapter;

public class BeanContainer : IBeanContainer
{
    public string Id => "2";
    public string Name => "Bean Container";

    public async Task<Result> ReleaseAsync(Mass mass)
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        return Result.Success();
    }
}