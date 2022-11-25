// <copyright file="Grinder.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using CoffeeBrewing.Contracts;
using CoffeeBrewing.Contracts.States;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.ErrorHandling;
using Zeiss.Semi.Mask.Foundation.MachineInterfaces.Contracts.Actuators;

namespace HardwareAdapter;

public class Grinder : Actuator<GrinderState>, IGrinder
{

    public Task<Result> GrindAsync()
    {
        this.State = new GrinderGrindingState();

        return Task.FromResult(Result.Success());
    }

    public Task<Result> StopGrindingAsync()
    {
        this.State = new GrinderIdleState();

        return Task.FromResult(Result.Success());
    }

    public Grinder() : base(new GrinderIdleState(), "Grinder")
    {
    }
}