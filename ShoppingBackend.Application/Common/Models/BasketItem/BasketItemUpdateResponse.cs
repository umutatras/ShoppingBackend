namespace ShoppingBackend.Application.Common.Models.BasketItem;

public class BasketItemUpdateResponse
{
    public int Id { get; set; }
    public int ProductId { get; set; }

    public int BasketId { get; set; }

    public int Quantity { get; set; }
}
