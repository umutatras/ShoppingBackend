using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ShoppingBackend.Application.Common.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
