using MediatR;
using Persistence.Context;
using Application.Features.Mediator.Commands.TagCommands;

namespace Application.Features.Mediator.Handlers.TagHandlers;

public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
{
    private readonly MovieContext _context;

    public UpdateTagCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var value = await _context.Tags.FindAsync(request.TagId);
        value.Title = request.Title;
        _context.Tags.Update(value);
    }
}
