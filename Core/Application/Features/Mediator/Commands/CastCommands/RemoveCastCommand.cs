using MediatR;

namespace Application.Features.Mediator.Commands.CastCommands;
public class RemoveCastCommand : IRequest
{
    public RemoveCastCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
