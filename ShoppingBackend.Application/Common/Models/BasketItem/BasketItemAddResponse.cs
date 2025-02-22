namespace ShoppingBackend.Application.Common.Models.BasketItem;

public class BasketItemAddResponse
{
    public int ProductId { get; set; }

    public int BasketId { get; set; }

    public int Quantity { get; set; }
}
