namespace ShoppingBackend.Application.Features.Basket.Query.GetAll;

public sealed record GetAllBasketDto
{

    public int Id { get; set; }
    public string UserId { get; set; }
    public GetAllBasketDto(int id, string userId)
    {
        Id = id;
        UserId = userId;
    }
    public GetAllBasketDto()
    {

    }
}
