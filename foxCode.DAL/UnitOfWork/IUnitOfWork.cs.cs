using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public interface IUnitOfWork
{
    public IProductsRepo ProductsRepo { get;}
    public ICategoriesRepo CategoriesRepo { get;}
    int saveChanges();
}
