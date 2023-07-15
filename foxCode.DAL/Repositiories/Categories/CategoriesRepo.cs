using foxCode.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public class CategoriesRepo : GenericRepo<Category>, ICategoriesRepo
{
    private readonly foxCodeContext _context;
    public CategoriesRepo(foxCodeContext context) : base(context)
    {
        _context=context;
    }

    public IEnumerable<Category>? GetAllCategoriesWithAllPrdoucts()
    {
        return _context.Set<Category>().Include(c=>c.Products);
    }

    public Category? GetProductsByCategoryId(Guid categoryId)
    {
        return _context.Set<Category>().Include(c => c.Products).FirstOrDefault(c=>c.Id==categoryId);
    }
}
