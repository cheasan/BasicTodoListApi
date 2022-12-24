using BasicToDoListApi.Core.DTO;
using BasicToDoListApi.Data;
using BasicToDoListApi.Models;
using BasicToDoListApi.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BasicToDoListApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(ILogger<CategoryController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Id = Guid.NewGuid();

                await _unitOfWork.Categories.Add(category);
                await _unitOfWork.Save();

                return Ok(new StandardResponseDto
                {
                    Data = new []{category}
                });
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }
    }
}