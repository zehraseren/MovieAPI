using MediatR;
using Persistence.Context;
using Application.Features.Mediator.Commands.CastCommands;

namespace Application.Features.Mediator.Handlers.CastHandlers;

public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand>
{
    private readonly MovieContext _context;

    public RemoveCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
    {
        var value = await _context.Casts.FindAsync(request.Id);
        _context.Casts.Remove(value);
        await _context.SaveChangesAsync();
    }
}
