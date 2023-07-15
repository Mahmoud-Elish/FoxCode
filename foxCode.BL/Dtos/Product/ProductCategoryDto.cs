using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.BL;

public class ProductCategoryDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }


    public Guid CatId { get; set; }
    public string? CatName { get; set; }
}
