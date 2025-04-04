using MediatR;
using Persistence.Context;
using Application.Features.Mediator.Commands.TagCommands;

namespace Application.Features.Mediator.Handlers.TagHandlers;

public class RemoveTagCommandHandler : IRequestHandler<RemoveTagCommand>
{
    private readonly MovieContext _context;

    public RemoveTagCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(RemoveTagCommand request, CancellationToken cancellationToken)
    {
        var value = await _context.Tags.FindAsync(request.Id);
        _context.Tags.Remove(value);
        await _context.SaveChangesAsync();
    }
}
