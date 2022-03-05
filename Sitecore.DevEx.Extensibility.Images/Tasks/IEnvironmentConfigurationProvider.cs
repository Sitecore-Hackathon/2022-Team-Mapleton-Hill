using Sitecore.DevEx.Configuration.Models;
using System.Threading.Tasks;

namespace Sitecore.DevEx.Extensibility.Images.Tasks
{
    public interface IEnvironmentConfigurationProvider
    {
        Task<EnvironmentConfiguration> GetEnvironmentConfigurationAsync(string currentDirectory, string environmentName);
    }
}