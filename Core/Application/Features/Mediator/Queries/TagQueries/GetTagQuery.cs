using MediatR;
using Application.Features.Mediator.Results.TagResults;

namespace Application.Features.Mediator.Queries.TagQueries;

public class GetTagQuery : IRequest<List<GetTagQueryResult>>
{
}
