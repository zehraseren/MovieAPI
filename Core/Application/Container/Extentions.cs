using Microsoft.Extensions.DependencyInjection;
using Application.Features.CQRS.Handlers.MovieHandlers;
using Application.Features.CQRS.Handlers.CategoryHandlers;

namespace Application.Container;

public static class Extentions
{
    public static void ContainerDependencies(this IServiceCollection services)
    {
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
    }
}
