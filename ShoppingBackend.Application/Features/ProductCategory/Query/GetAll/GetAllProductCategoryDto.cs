namespace ShoppingBackend.Application.Features.ProductCategory.Query.GetAll;

public sealed record GetAllProductCategoryDto
{

    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public GetAllProductCategoryDto(int id, int productId,int categoryId)
    {
        Id = id;
        ProductId = productId;
        CategoryId = categoryId;
    }
    public GetAllProductCategoryDto()
    {

    }
}
