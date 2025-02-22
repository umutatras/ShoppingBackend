using ShoppingBackend.Domain.Common;

namespace ShoppingBackend.Domain.Entities;

public sealed class Basket : EntityBase<int>
{
    public Guid UserId { get; set; }
    public List<BasketItem> BasketItems { get; set; } = new();
}
