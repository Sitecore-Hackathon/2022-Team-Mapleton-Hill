using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Text;

namespace Sitecore.DevEx.Extensibility.Images.Commands
{
    class ImagesCommand : Command, ISubcommand
    {
        public ImagesCommand(string name, string description = null) : base(name, description)
        {

        }
    }
}
