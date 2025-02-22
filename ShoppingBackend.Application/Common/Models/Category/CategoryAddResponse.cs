using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Common.Models.Category;

public class CategoryAddResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}
