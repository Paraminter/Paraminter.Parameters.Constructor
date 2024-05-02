namespace Paraminter.Parameters;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services provided by <i>Paraminter.Parameters.Constructor</i> to be registered with <see cref="IServiceCollection"/>.</summary>
public static class ParaminterConstructorParametersServices
{
    /// <summary>Registers the services provided by <i>Paraminter.Parameters.Constructor</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddParaminterConstructorParameters(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<IConstructorParameterFactory, ConstructorParameterFactory>();

        return services;
    }
}
