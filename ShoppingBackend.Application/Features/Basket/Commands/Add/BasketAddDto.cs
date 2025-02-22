using ShoppingBackend.Application.Common.Models.Basket;

namespace ShoppingBackend.Application.Features.Basket.Commands.Add;

public class BasketAddDto
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public BasketAddDto(int id, string userId)
    {
        Id = id;
        UserId = userId;
    }
    public static BasketAddDto Create(BasketAddResponse basketAddResponse)
    {
        return new BasketAddDto(basketAddResponse.Id, basketAddResponse.UserId);
    }
}
