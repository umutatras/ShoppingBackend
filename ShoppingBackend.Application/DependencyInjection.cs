using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShoppingBackend.Application.Common.Behaviours;
using System.Reflection;

namespace ShoppingBackend.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicaton(this IServiceCollection services)
    {
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                config.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviours<,>));
            });
            return services;
        }
    }
}
