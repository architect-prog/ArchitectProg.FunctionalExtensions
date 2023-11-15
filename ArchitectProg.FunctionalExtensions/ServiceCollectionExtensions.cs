using ArchitectProg.FunctionalExtensions.Factories;
using ArchitectProg.FunctionalExtensions.Factories.Interfaces;
using ArchitectProg.FunctionalExtensions.Services;
using ArchitectProg.FunctionalExtensions.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectProg.FunctionalExtensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFunctionalExtensions(this IServiceCollection serviceCollection)
    {
        ArgumentNullException.ThrowIfNull(serviceCollection);

        serviceCollection.AddScoped<IAssemblyFileReader, AssemblyFileReader>();
        serviceCollection.AddScoped<IDateTimeFormatter, DateTimeFormatter>();
        serviceCollection.AddScoped<IDateTimeProvider, DateTimeProvider>();
        serviceCollection.AddScoped<IEnumItemFactory, EnumItemFactory>();

        serviceCollection.AddSingleton<IJsonSerializer, JsonSerializer>();

        return serviceCollection;
    }
}