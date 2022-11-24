// <copyright file="Grinder.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;

namespace HardwareAdapter;

public class Grinder : IGrinder
{
    public string Id { get; }
    public string Name { get; }

    public Grinder()
    {
        Id = "16";
        Name = "Grinder";
    }

    public Task<Result> GrindAsync()
    {
        return Task.FromResult(Result.Success());
    }

    public Task<Result> StopGrindingAsync()
    {
        return Task.FromResult(Result.Success());
    }
}