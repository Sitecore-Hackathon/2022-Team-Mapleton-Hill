using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Sitecore.DevEx.Client.Tasks;
using Sitecore.DevEx.Extensibility.Images.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.DevEx.Extensibility.Images.Commands
{
    public class CleanImagesCommand : SubcommandBase<CleanImageTask, CleanImageArgs>
    {
        public CleanImagesCommand(IServiceProvider container): base("clean", "Clean unused images", container)
        {
            this.AddOption(ArgOptions.EnvironmentName);
            this.AddOption(ArgOptions.Config);
            this.AddOption(ArgOptions.Verbose);
            this.AddOption(ArgOptions.Trace);
        }


        protected override async Task<int> Handle(CleanImageTask task, CleanImageArgs args)
        {
          ((TaskOptionsBase) args).Validate();
          await task.Execute(args).ConfigureAwait(false);
          return 0;
        }
    }
}
