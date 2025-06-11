using Persistence.Context;
using Persistence.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Application.Features.CQRS.Handlers.MovieHandlers;
using Application.Features.CQRS.Handlers.CategoryHandlers;
using Application.Features.CQRS.Handlers.UserRegisterHandlers;

namespace Application.Container;

public static class Extentions
{
    public static void ContainerDependencies(this IServiceCollection services)
    {
        // Identity Configuration
        services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MovieContext>()
            .AddDefaultTokenProviders();

        // CQRS Handlers
        services.AddScoped<GetMovieQueryHandler>();
        services.AddScoped<GetMovieByIdQueryHandler>();
        services.AddScoped<CreateMovieCommandHandler>();
        services.AddScoped<RemoveMovieCommandHandler>();
        services.AddScoped<UpdateMovieCommandHandler>();

        services.AddScoped<GetCategoryQueryHandler>();
        services.AddScoped<GetCategoryByIdQueryHandler>();
        services.AddScoped<CreateCategoryCommandHandler>();
        services.AddScoped<RemoveCategoryCommandHandler>();
        services.AddScoped<UpdateCategoryCommandHandler>();

        services.AddScoped<CreateUserRegisterCommandHandler>();
    }
}
