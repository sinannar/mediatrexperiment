using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomMediator
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services, params Type[] types)
        {
            var assemblies = types.Select(t => t.GetTypeInfo().Assembly).ToList();
            var distinctTypes = assemblies.SelectMany(a => a.GetTypes())
                .Distinct()
                .Where(t => t.GetInterfaces().Where(t2 => t2.IsGenericType && t2.GetGenericTypeDefinition() == typeof(IRequestHandler<,>)).Count() > 0)
                .ToList();


            foreach (var type in distinctTypes)
            {
                var handlerInterface = type.GetInterfaces().Where(t2 => t2.IsGenericType && t2.GetGenericTypeDefinition() == typeof(IRequestHandler<,>)).First();
                services.AddScoped(handlerInterface, type);
            }

            services.AddScoped<IMediator, Mediator>();

            return services;
        }
    }
}
