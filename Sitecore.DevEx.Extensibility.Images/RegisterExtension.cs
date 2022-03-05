using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Sitecore.Devex.Client.Cli.Extensibility;
using Sitecore.Devex.Client.Cli.Extensibility.Subcommands;
using Sitecore.DevEx.Extensibility.Images.Commands;
using Sitecore.DevEx.Extensibility.Images.Tasks;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.Text;

namespace Sitecore.DevEx.Extensibility.Images
{
    public class RegisterExtension : ISitecoreCliExtension
    {
        public IEnumerable<ISubcommand> AddCommands(IServiceProvider container) => (IEnumerable<ISubcommand>)new ISubcommand[1]
        {
            RegisterExtension.CreateIndexCommand(container)
        };

        public void AddConfiguration(IConfigurationBuilder configBuilder)
        {
        }

        public void AddServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<CleanImagesCommand>().AddSingleton<ILogger<CleanImageTask>>((Func<IServiceProvider, ILogger<CleanImageTask>>)(t => t.GetService<ILoggerFactory>().CreateLogger<CleanImageTask>()));
            serviceCollection.TryAddTransient<IEnvironmentConfigurationProvider, EnvironmentConfigurationProvider>();
        }

        private static ISubcommand CreateIndexCommand(IServiceProvider container)
        {
            ImagesCommand imagesCommand = new ImagesCommand("images", "working with images data");
            ((Symbol)imagesCommand).AddAlias("images");
            imagesCommand.AddCommand((Command)container.GetRequiredService<CleanImagesCommand>());
            return (ISubcommand)imagesCommand;
        }
    }
}
