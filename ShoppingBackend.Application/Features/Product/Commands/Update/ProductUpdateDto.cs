using ShoppingBackend.Application.Common.Models.Product;

namespace ShoppingBackend.Application.Features.Product.Commands.Update;

public sealed class ProductUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public int StockAmount { get; set; }
    public ProductUpdateDto(int id, string name, string code, int stockAmount)
    {
        Id = id;
        Name = name;
        Code = code;
        StockAmount = stockAmount;
    }

    public static ProductUpdateDto Update(ProductUpdateResponse response)
    {
        return new ProductUpdateDto(response.Id, response.Name, response.Code, response.StockAmount);
    }
}
