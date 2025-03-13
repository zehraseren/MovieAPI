using MediatR;
using Persistence.Context;
using Application.Features.Mediator.Results.CastResults;
using Application.Features.Mediator.Queries.CastQueries;

namespace Application.Features.Mediator.Handlers.CastHandlers;

public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
{
    private readonly MovieContext _context;

    public GetCastByIdQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _context.Casts.FindAsync(request.Id);
        return new GetCastByIdQueryResult
        {
            Title = value.Title,
            Name = value.Name,
            Surname = value.Surname,
            ImageUrl = value.ImageUrl,
            Overview = value.Overview,
            Biography = value.Biography,
        };
    }
}
