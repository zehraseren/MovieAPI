using MediatR;
using Application.Features.Mediator.Results.CastResults;

namespace Application.Features.Mediator.Queries.CastQueries;

public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
{
    public GetCastByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
