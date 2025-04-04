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
    public IActionResult CastList()
    {
        var value = _mediator.Send(new GetCastQuery());
        return Ok(value);
    }

    [HttpGet("{id}")]
    public IActionResult GetCastById(int id)
    {
        var value = _mediator.Send(new GetCastByIdQuery(id));
        return Ok(value);
    }

    [HttpPost]
    public IActionResult CReateCast(CreateCastCommand command)
    {
        _mediator.Send(command);
        return Ok("Ekleme işlemi başarılı.");
    }

    [HttpDelete]
    public IActionResult DeleteCast(int id)
    {
        _mediator.Send(new RemoveCastCommand(id));
        return Ok("Silme işlemi başarılı.");
    }

    [HttpPut]
    public IActionResult UpdateCast(UpdateCastCommand command)
    {
        _mediator.Send(command);
        return Ok("Güncelleme işlemi başarılı.");
    }
}
