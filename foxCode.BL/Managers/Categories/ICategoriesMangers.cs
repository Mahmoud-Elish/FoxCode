using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.BL;

public interface ICategoriesMangers
{
    IEnumerable<ProductReadDto>? GetProductsByCategoryId(Guid categoryId);
    IEnumerable<CategoryWithProductsDto> GetAllCategories();
    CategoryWithProductsDto? GetCategoryById(Guid CategoryId);
}
