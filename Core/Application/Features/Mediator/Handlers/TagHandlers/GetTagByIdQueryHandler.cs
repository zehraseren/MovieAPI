using MediatR;
using Persistence.Context;
using Application.Features.Mediator.Queries.TagQueries;
using Application.Features.Mediator.Results.TagResults;

namespace Application.Features.Mediator.Handlers.TagHandlers;

public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
{
    private readonly MovieContext _context;

    public GetTagByIdQueryHandler(MovieContext context)
    {
        _context = context;
    }

    public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _context.Tags.FindAsync(request.Id);
        return new GetTagByIdQueryResult
        {
            Title = value.Title
        };
    }
}
