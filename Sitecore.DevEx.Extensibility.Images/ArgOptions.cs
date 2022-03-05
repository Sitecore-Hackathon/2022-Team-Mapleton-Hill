﻿using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Text;

namespace Sitecore.DevEx.Extensibility.Images
{
    internal static class ArgOptions
    {
        internal static readonly Option Config = new Option(new string[2]
        {
            "--config",
            "-c"
        }, "Path to root sitecore.json directory (default: cwd)")
        {
            Argument = (Argument)new Argument<string>((Func<string>)(() => Environment.CurrentDirectory))
        };
        internal static readonly Option EnvironmentName = new Option(new string[2]
        {
          "--environment-name",
          "-n"
        }, "Named Sitecore environment to use. Default: 'default'.")
        {
            Argument = (Argument)new Argument<string>()
        };
        internal static readonly Option Verbose = new Option(new string[2]
        {
          "--verbose",
          "-v"
        }, "Write some additional diagnostic and performance data")
        {
            Argument = (Argument)new Argument<bool>((Func<bool>)(() => false))
        };
        internal static readonly Option Trace = new Option(new string[2]
        {
          "--trace",
          "-t"
        }, "Write more additional diagnostic and performance data")
        {
            Argument = (Argument)new Argument<bool>((Func<bool>)(() => false))
        };
    }
}
