namespace Application.Features.CQRS.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public GetMovieByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
