using Microsoft.AspNetCore.Mvc;
using Application.Features.CQRS.Handlers.UserRegisterHandlers;
using Application.Features.CQRS.Commands.UserRegisterCommands;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserRegistersController : ControllerBase
{
    private readonly CreateUserRegisterCommandHandler _handler;

    public UserRegistersController(CreateUserRegisterCommandHandler handler)
    {
        _handler = handler;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserRegister(CreateUserRegisterCommand command)
    {
        await _handler.Handle(command);
        return Ok("Kullanıcı başarıyla eklendi.");
    }
}
