using Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Application.Features.CQRS.Results.CategoryResults;

namespace Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly MovieContext _context;

        public GetCategoryQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _context.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
            }).ToList();
        }
    }
}
