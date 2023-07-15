using foxCode.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public class Product
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; } 
    public decimal Price { get; set; }


    public Guid CategoryID { get; set; }
    public Category? Category { get; set; }
}
