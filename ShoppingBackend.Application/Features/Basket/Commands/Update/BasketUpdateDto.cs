using ShoppingBackend.Application.Common.Models.Basket;

namespace ShoppingBackend.Application.Features.Basket.Commands.Update;

public class BasketUpdateDto
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
    public BasketUpdateDto(int id, string userId)
    {
        Id = id;
        UserId = userId;
    }

    public static BasketUpdateDto Update(BasketUpdateResponse response)
    {
        return new BasketUpdateDto(response.Id, response.UserId);
    }
}
