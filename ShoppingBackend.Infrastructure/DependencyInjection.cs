using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Domain.Settings;
using ShoppingBackend.Infrastructure.Identity;
using ShoppingBackend.Infrastructure.Persistance.Contexts;
using ShoppingBackend.Infrastructure.Services;

namespace ShoppingBackend.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(connectionString));

        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<IBasketService, BasketManager>();
        services.AddScoped<IBasketItemService, BasketItemManager>();

        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

        services.AddScoped<IJwtService, JwtManager>();

        services.AddScoped<IIdentityService, IdentityManager>();


        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.User.RequireUniqueEmail = true;

            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireDigit = false;
            options.Password.RequiredUniqueChars = 0;
            options.Password.RequiredLength = 6;
        })
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();


        return services;
    }
}
