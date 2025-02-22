using ShoppingBackend.Application.Common.Models.BasketItem;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Update;

public class BasketItemUpdateDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }

    public int BasketId { get; set; }

    public int Quantity { get; set; }
    public BasketItemUpdateDto(int id, int productId, int basketId, int quantity)
    {
        Id = id;
        ProductId = productId;
        BasketId = basketId;
        Quantity = quantity;
    }
    public static BasketItemUpdateDto Update(BasketItemUpdateResponse response)
    {
        return new BasketItemUpdateDto(response.Id, response.ProductId, response.BasketId, response.Quantity);
    }
}
