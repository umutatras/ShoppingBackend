using ShoppingBackend.Application.Common.Models.ProductCategory;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Add;

public class ProductCategoryAddDto
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }
    public ProductCategoryAddDto(int productId, int categoryId)
    {
        ProductId = productId;
        CategoryId = categoryId;
    }
    public static ProductCategoryAddDto Create(ProductCategoryAddResponse response)
    {
        return new ProductCategoryAddDto(response.ProductId, response.CategoryId);
    }
}
