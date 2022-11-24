// <copyright file="Logger.cs" company="Carl Zeiss">
//   © ZEISS. All rights reserved.
// </copyright>

using System;
using Zeiss.Semi.Mask.Foundation.Common.Contracts.Logging;

namespace Starter;

public class Logger : BaseLogger
{
    public override void Debug(string area, string message)
    {
    }

    public override void Debug(string area, string message, Exception exception)
    {
    }

    public override void Trace(string area, string message)
    {
    }

    public override void Trace(string area, string message, Exception exception)
    {
    }

    public override void Info(string area, string message)
    {
    }

    public override void Info(string area, string message, Exception exception)
    {
    }

    public override void Warning(string area, string message)
    {
    }

    public override void Warning(string area, string message, Exception exception)
    {
    }

    public override void Error(string area, string message)
    {
    }

    public override void Error(string area, string message, Exception exception)
    {
    }

    public override void Fatal(string area, string message)
    {
    }

    public override void Fatal(string area, string message, Exception exception)
    {
    }
}