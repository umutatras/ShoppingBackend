using ShoppingBackend.Domain.Common;

namespace ShoppingBackend.Domain.Entities;

public class BasketItem : EntityBase<int>
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int BasketId { get; set; }
    public Basket Basket { get; set; } = null!;

    public int Quantity { get; set; }
}
