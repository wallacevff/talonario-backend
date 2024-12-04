using Talonario.Api.Extensions;
using Talonario.Infra.CrossCutting.Providers;

namespace Talonario.Api.Factories;

public static class WebApplicationBuilderFactory
{
    public static WebApplication CreateWebApplication(params string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = CustomConfigurationProvider.GetConfiguration(builder.Environment);
        builder.Configuration.AddConfiguration(configuration);
        builder.Services.AddControllers();
        builder.AddSwaggerBuilder();
        builder.AddCorsBuilder();
        builder.ConfigureAuthentication();


        return builder.Build();
    }
}