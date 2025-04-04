using MediatR;

namespace Application.Features.Mediator.Commands.TagCommands;

public class CreateTagCommand : IRequest
{
    public string Title { get; set; }
}
