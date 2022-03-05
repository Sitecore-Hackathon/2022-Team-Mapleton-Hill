using Microsoft.Extensions.Logging;
using Sitecore.DevEx.Client.Logging;
using Sitecore.DevEx.Configuration.Models;
using Sitecore.DevEx.Extensibility.Images.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.DevEx.Extensibility.Images.Tasks
{
    public class CleanImageTask
    {
        private readonly IEnvironmentConfigurationProvider _configurationProvider;
        protected readonly ILogger Logger;

        protected string TaskStartText => "Cleaning";

        protected string TaskEndText => "Unsused images have been cleaned";

        protected string AllFailedText => "Unsused images failed to be cleaned";

        public CleanImageTask(ILogger<CleanImageTask> logger, IEnvironmentConfigurationProvider configurationProvider)
        {
            this.Logger = logger;
            this._configurationProvider = configurationProvider;
        }

        public async Task Execute(CleanImageArgs options)
        {
            EnvironmentConfiguration environmentConfiguration = await this._configurationProvider.GetEnvironmentConfigurationAsync(options.Config, options.EnvironmentName);
            Stopwatch stopwatch = Stopwatch.StartNew();

            ColorLogExtensions.LogConsoleVerbose(this.Logger, string.Format("{0} finished in {1}ms.", (object) this.TaskStartText, (object) stopwatch.ElapsedMilliseconds), new ConsoleColor?(), new ConsoleColor?());
            environmentConfiguration = (EnvironmentConfiguration) null;
            stopwatch = (Stopwatch) null;
        }
    }
}
