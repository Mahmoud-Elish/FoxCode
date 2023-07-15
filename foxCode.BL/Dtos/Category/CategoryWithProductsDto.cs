using foxCode.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.BL;

public class CategoryWithProductsDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ICollection<ProductChild>? Products { get; set; }
}
