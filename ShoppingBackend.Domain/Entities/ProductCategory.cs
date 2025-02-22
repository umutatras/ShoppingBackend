using ShoppingBackend.Domain.Common;

namespace ShoppingBackend.Domain.Entities;

public sealed class ProductCategory : EntityBase<int>
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}
