﻿using Persistence.Context;
using Application.Features.CQRS.Commands.CategoryCommands;

namespace Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveCategoryCommand command)
        {
            var value = await _context.Movies.FindAsync(command.CategoryId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
