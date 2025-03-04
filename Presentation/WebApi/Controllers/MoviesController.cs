using Microsoft.AspNetCore.Mvc;
using Application.Features.CQRS.Queries.MovieQueries;
using Application.Features.CQRS.Handlers.MovieHandlers;
using Application.Features.CQRS.Commands.MovieCommands;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly GetMovieQueryHandler _getMovieQueryHandler;
        private readonly GetMovieByIdQueryHandler _getMovieByIdQueryHandler;
        private readonly CreateMovieCommandHandler _createMovieCommandHandler;
        private readonly RemoveMovieCommandHandler _removeMovieCommandHandler;
        private readonly UpdateMovieCommandHandler _updateMovieCommandHandler;

        public MoviesController(GetMovieQueryHandler getMovieQueryHandler, GetMovieByIdQueryHandler getMovieByIdQueryHandler, CreateMovieCommandHandler createMovieCommandHandler, RemoveMovieCommandHandler removeMovieCommandHandler, UpdateMovieCommandHandler updateMovieCommandHandler)
        {
            _getMovieQueryHandler = getMovieQueryHandler;
            _getMovieByIdQueryHandler = getMovieByIdQueryHandler;
            _createMovieCommandHandler = createMovieCommandHandler;
            _removeMovieCommandHandler = removeMovieCommandHandler;
            _updateMovieCommandHandler = updateMovieCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> MovieList()
        {
            var values = await _getMovieQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(int id)
        {
            var value = await _getMovieByIdQueryHandler.Handle(new GetMovieByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieCommand command)
        {
            await _createMovieCommandHandler.Handle(command);
            return Ok("Film başarıyla eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _removeMovieCommandHandler.Handle(new RemoveMovieCommand(id));
            return Ok("Film başarıyla silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMovie(UpdateMovieCommand command)
        {
            await _updateMovieCommandHandler.Handle(command);
            return Ok("Film başarıyla güncellendi.");
        }
    }
}
