using ShoppingBackend.Application.Common.Models.Product;

namespace ShoppingBackend.Application.Features.Product.Query.GetAll;

public sealed record GetAllProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public int StockAmount { get; set; }
    public List<ProductCategories> Categories { get; set; }
    public GetAllProductDto(int id, string name, string code, int stockAmount, List<ProductCategories> categories)
    {
        Id = id;
        Name = name;
        Code = code;
        StockAmount = stockAmount;
        Categories = categories;
    }
    public GetAllProductDto()
    {

    }
}
