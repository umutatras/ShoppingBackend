using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Common.Models.Product;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Product.Commands.Add;

public sealed class ProductAddDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public int StockAmount { get; set; }

    public ProductAddDto(int id, string name, string code, int stockAmount)
    {
        Id = id;
        Name = name;
        Code = code;
        StockAmount = stockAmount;
    }

    public static ProductAddDto Create(ProductAddResponse response)
    {
        return new ProductAddDto(response.Id, response.Name, response.Code, response.StockAmount);
    }
}
