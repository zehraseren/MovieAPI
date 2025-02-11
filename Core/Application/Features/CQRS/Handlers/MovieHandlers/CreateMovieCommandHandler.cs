using Domain.Entities;
using Persistence.Context;
using Application.Features.CQRS.Commands.MovieCommands;

namespace Application.Features.CQRS.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Hanlde(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                Title = command.Title,
                CoverImageUrl = command.CoverImageUrl,
                Rating = command.Rating,
                Description = command.Description,
                Duration = command.Duration,
                ReleaseDate = command.ReleaseDate,
                CreatedYear = command.CreatedYear,
                Status = command.Status,
            });

            await _context.SaveChangesAsync();
        }
    }
}
