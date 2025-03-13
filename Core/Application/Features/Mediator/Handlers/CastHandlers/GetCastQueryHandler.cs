using MediatR;
using Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Application.Features.Mediator.Results.CastResults;
using Application.Features.Mediator.Queries.CastQueries;

namespace Application.Features.Mediator.Handlers.CastHandlers;

public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
{
    private readonly MovieContext _context;

    public GetCastQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Casts.ToListAsync();
        return values.Select(x => new GetCastQueryResult
        {
            Title = x.Title,
            Name = x.Name,
            Surname = x.Surname,
            ImageUrl = x.ImageUrl,
            Overview = x.Overview,
            Biography = x.Biography,
        }).ToList();
    }
}
