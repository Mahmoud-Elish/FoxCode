using foxCode.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.BL;

public class CategoriesMangers : ICategoriesMangers
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoriesMangers(IUnitOfWork unitOfWork)
    {
        _unitOfWork=unitOfWork;
    }
    public IEnumerable<CategoryWithProductsDto> GetAllCategories()
    {
        return _unitOfWork.CategoriesRepo.GetAllCategoriesWithAllPrdoucts()!.Select(
            c => new CategoryWithProductsDto
            {
                Id = c.Id,
                Name = c.Name,
                Products = c.Products?.Select(p => new ProductChild
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    CatName = c.Name

                }).ToList()
            }
            );
    }

    public CategoryWithProductsDto? GetCategoryById(Guid CategoryId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ProductReadDto>? GetProductsByCategoryId(Guid categoryId)
    {
        throw new NotImplementedException();
    }
}
