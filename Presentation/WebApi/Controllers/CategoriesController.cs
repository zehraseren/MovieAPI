using Microsoft.AspNetCore.Mvc;
using Application.Features.CQRS.Queries.CategoryQueries;
using Application.Features.CQRS.Handlers.CategoryHandlers;
using Application.Features.CQRS.Commands.CategoryCommands;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

        public CategoriesController(GetCategoryQueryHandler getCategoryQueryHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _createCategoryCommandHandler.Handle(command);
            return Ok("Kategori eklendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return Ok("Kategori silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Kategori güncellendi.");
        }
    }
}
