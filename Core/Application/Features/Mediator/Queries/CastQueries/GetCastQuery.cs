using MediatR;
using Application.Features.Mediator.Results.CastResults;

namespace Application.Features.Mediator.Queries.CastQueries;

public class GetCastQuery : IRequest<List<GetCastQueryResult>>
{
}
