using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Troy.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TemporaryDirectoryNameConvention"/> implementation of <see cref="ITemporaryDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultTemporaryDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<ITemporaryDirectoryNameConvention, TemporaryDirectoryNameConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TemporaryDirectoryNameConvention"/> implementation of <see cref="ITemporaryDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ITemporaryDirectoryNameConvention> AddDefaultTemporaryDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITemporaryDirectoryNameConvention>(() => services.AddDefaultTemporaryDirectoryNameConvention());
            return serviceAction;
        }
    }
}
