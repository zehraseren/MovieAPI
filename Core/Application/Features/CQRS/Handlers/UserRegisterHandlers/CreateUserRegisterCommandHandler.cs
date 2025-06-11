using Persistence.Context;
using Persistence.Identity;
using Microsoft.AspNetCore.Identity;
using Application.Features.CQRS.Commands.UserRegisterCommands;

namespace Application.Features.CQRS.Handlers.UserRegisterHandlers;

public class CreateUserRegisterCommandHandler
{
    private readonly MovieContext _context;
    private readonly UserManager<AppUser> _userManager;
    public CreateUserRegisterCommandHandler(MovieContext context, UserManager<AppUser> userManager = null)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task Handle(CreateUserRegisterCommand command)
    {
        var user = new AppUser
        {
            UserName = command.Username,
            Email = command.Email,
            Name = command.Name,
            Surname = command.Surname
        };

        await _userManager.CreateAsync(user, command.Password);
    }
}
