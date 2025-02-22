using ShoppingBackend.Domain.Common;

namespace ShoppingBackend.Domain.Entities;

public sealed class Product : EntityBase<int>
{
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public int StockAmount { get; set; }

    public List<ProductCategory> ProductCategories { get; set; } = new();
}
