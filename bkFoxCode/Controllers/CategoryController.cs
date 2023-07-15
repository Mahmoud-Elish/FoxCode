using foxCode.BL;
using foxCode.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bkFoxCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesMangers _categoriesMangers;

        public CategoryController(ICategoriesMangers categoriesMangers)
        {
            _categoriesMangers = categoriesMangers;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryWithProductsDto>> AllProducts()
        {
            return _categoriesMangers.GetAllCategories().ToList();
        }
    }
}
