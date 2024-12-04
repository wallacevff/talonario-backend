using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Talonario.Infra.CrossCutting.Providers;

public static class CustomConfigurationProvider
{
    private const string PATH_TO_JSON = "ConfigurationEnvironment";
    private const string STANDARD_JSON = "appsettings";
    public static IConfiguration GetConfiguration()
    {
        string path = Path.Combine(PATH_TO_JSON, $"{STANDARD_JSON}.json");
        return new ConfigurationBuilder().AddJsonFile(path).Build();
    }

    public static IConfiguration GetConfiguration(IHostEnvironment environment)
    {
        string path;
        if (string.Equals(environment.EnvironmentName, Environments.Production))
        {
            path = Path.Combine(PATH_TO_JSON, "appsettings.json");
            return new ConfigurationBuilder().AddJsonFile(path).Build();
        }
        path = Path.Combine(PATH_TO_JSON, $"{STANDARD_JSON}.{Environments.Development}.json");
        return new ConfigurationBuilder().AddJsonFile(path).Build();
    }
}