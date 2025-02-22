using ShoppingBackend.Domain.Common;

namespace ShoppingBackend.Domain.Entities;

public sealed class Category : EntityBase<int>
{
    public string Name { get; set; } = null!;

    public List<ProductCategory> ProductCategories { get; set; } = new();
}
