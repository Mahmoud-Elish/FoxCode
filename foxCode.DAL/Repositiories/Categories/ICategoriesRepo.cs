using foxCode.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public interface ICategoriesRepo:IGenericRepo<Category>
{
    IEnumerable<Category>? GetAllCategoriesWithAllPrdoucts();
    Category? GetProductsByCategoryId(Guid categoryId);
}
