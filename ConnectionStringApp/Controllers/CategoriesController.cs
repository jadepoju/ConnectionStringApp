using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectionStringApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace ConnectionStringApp.Controllers
{
    [Route("api/v1/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        //DI
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetAllCategory()
        {
            var categories = _categoryRepository.GetCategories();
            return Ok(categories);
        }

        [HttpGet("{categoryId}")]
        public IActionResult GetACategory([FromRoute] Guid categoryId)
        {
            if(categoryId == null)
            {
                return NotFound(); //404
            }

            var category = _categoryRepository.GetCategory(categoryId);
            return Ok(category);
        }
    }
}
