using MediatR;
using Domain.Entities;
using Persistence.Context;
using Application.Features.Mediator.Commands.CastCommands;

namespace Application.Features.Mediator.Handlers.CastHandlers;

public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
{
    private readonly MovieContext _context;

    public CreateCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
    {
        await _context.Casts.AddAsync(new Cast
        {
            Title = request.Title,
            Name = request.Name,
            Surname = request.Surname,
            ImageUrl = request.ImageUrl,
            Overview = request.Overview,
            Biography = request.Biography,
        });
        await _context.SaveChangesAsync();
    }
}
