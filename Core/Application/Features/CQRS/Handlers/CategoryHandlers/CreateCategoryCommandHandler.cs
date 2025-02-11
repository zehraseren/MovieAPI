using Domain.Entities;
using Persistence.Context;
using Application.Features.CQRS.Commands.CategoryCommands;

namespace Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName
            });

            await _context.SaveChangesAsync();
        }
    }
}
