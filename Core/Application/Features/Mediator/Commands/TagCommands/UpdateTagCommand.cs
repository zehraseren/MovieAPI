﻿using MediatR;

namespace Application.Features.Mediator.Commands.TagCommands;

public class UpdateTagCommand : IRequest
{
    public int TagId { get; set; }
    public string Title { get; set; }
}
