namespace ShoppingBackend.Application.Features.BasketItem.Query.GetAll;

public sealed record GetAllBasketItemDto
{

    public int Id { get; set; }
    public string UserId { get; set; }
    public GetAllBasketItemDto(int id, string userId)
    {
        Id = id;
        UserId = userId;
    }
    public GetAllBasketItemDto()
    {

    }
}
