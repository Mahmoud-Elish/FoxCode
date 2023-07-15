using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public class ProductsRepo : GenericRepo<Product>, IProductsRepo
{
    private readonly foxCodeContext _context;
    public ProductsRepo(foxCodeContext context) : base(context)
    {
        _context=context;
    }
}
