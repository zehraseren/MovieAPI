﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Mediator.Queries.TagQueries;
using Application.Features.Mediator.Commands.TagCommands;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TagsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TagsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> TagList()
    {
        var values = await _mediator.Send(new GetTagQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTag(int id)
    {
        var values = await _mediator.Send(new GetTagByIdQuery(id));
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTag(CreateTagCommand command)
    {
        await _mediator.Send(command);
        return Ok("Ekleme işlemi başarılı.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteTag(int id)
    {
        await _mediator.Send(new RemoveTagCommand(id));
        return Ok("Silme işlemi başarılı.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
    {
        await _mediator.Send(command);
        return Ok("Güncelleme işlemi başarılı.");
    }
}
