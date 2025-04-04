using MediatR;
using Application.Features.Mediator.Results.TagResults;

namespace Application.Features.Mediator.Queries.TagQueries;

public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
{
    public int Id { get; set; }

    public GetTagByIdQuery(int id)
    {
        Id = id;
    }
}
