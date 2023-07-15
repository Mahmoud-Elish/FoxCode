using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public class UnitOfWork:IUnitOfWork
{
    private readonly foxCodeContext _context;
    public IProductsRepo ProductsRepo { get; }
    public ICategoriesRepo CategoriesRepo { get; }
    public UnitOfWork(foxCodeContext context,IProductsRepo productsRepo,ICategoriesRepo categoriesRepo)
    {
        _context=context;
        ProductsRepo=productsRepo;
        CategoriesRepo=categoriesRepo;
    }

    public int saveChanges()
    {
        return _context.SaveChanges();
    }
}
