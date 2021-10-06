using System;
using Cart.User.GraphQL.Types.ObjectTypes;
using Cart.User.GraphQL.Types.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Cart.User.GraphQL
{
    public static class ServiceRegistrar
    {
        public static IServiceCollection UseCartGraphQL(this IServiceCollection services)
        {
            // Register GraphQL Services here
            services
                .AddGraphQLServer()
                .AddQueryType()
                    .AddTypeExtension<UserQueries>()
                .AddType<UserType>();
            return services;
        }
    }
}