namespace Application.Features.CQRS.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public RemoveMovieCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
