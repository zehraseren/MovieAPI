using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Mediator.Commands.CastCommands;
using Application.Features.Mediator.Queries.CastQueries;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CastsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CastsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> CastList()
    {
        var value = await _mediator.Send(new GetCastQuery());
        return Ok(value);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCastById(int id)
    {
        var value = await _mediator.Send(new GetCastByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCast(CreateCastCommand command)
    {
        await _mediator.Send(command);
        return Ok("Ekleme işlemi başarılı.");
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCast(int id)
    {
        await _mediator.Send(new RemoveCastCommand(id));
        return Ok("Silme işlemi başarılı.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCast(UpdateCastCommand command)
    {
        await _mediator.Send(command);
        return Ok("Güncelleme işlemi başarılı.");
    }
}
