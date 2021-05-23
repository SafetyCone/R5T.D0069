using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0069
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="EntryPointAssemblyBasedApplicationNameProvider"/> implementation of <see cref="IApplicationNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddEntryPointAssemblyBasedApplicationNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IApplicationNameProvider, EntryPointAssemblyBasedApplicationNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="EntryPointAssemblyBasedApplicationNameProvider"/> implementation of <see cref="IApplicationNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IApplicationNameProvider> AddEntryPointAssemblyBasedApplicationNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IApplicationNameProvider>(() => services.AddEntryPointAssemblyBasedApplicationNameProvider());
            return serviceAction;
        }
    }
}
