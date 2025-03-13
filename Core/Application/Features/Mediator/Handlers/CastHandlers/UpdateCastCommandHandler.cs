using MediatR;
using Persistence.Context;
using Application.Features.Mediator.Commands.CastCommands;

namespace Application.Features.Mediator.Handlers.CastHandlers;

public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
{
    private readonly MovieContext _context;

    public UpdateCastCommandHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
    {
        var value = await _context.Casts.FindAsync(request.CastId);
        value.Title = request.Title;
        value.Name = request.Name;
        value.Surname = request.Surname;
        value.ImageUrl = request.ImageUrl;
        value.Overview = request.Overview;
        value.Biography = request.Biography;
        await _context.SaveChangesAsync();
    }
}
