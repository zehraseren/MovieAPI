using MediatR;
using Domain.Entities;
using Persistence.Context;
using Application.Features.Mediator.Commands.TagCommands;

namespace Application.Features.Mediator.Handlers.TagHandlers;

public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
{
    private readonly MovieContext _context;

    public CreateTagCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        _context.Tags.Add(new Tag
        {
            Title = request.Title
        });
        await _context.SaveChangesAsync();
    }
}
