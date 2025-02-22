using ShoppingBackend.Application.Common.Models.ProductCategory;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Update;

public class ProductCategoryUpdateDto
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }
    public ProductCategoryUpdateDto(int productId, int categoryId)
    {
        ProductId = productId;
        CategoryId = categoryId;
    }
    public static ProductCategoryUpdateDto Update(ProductCategoryUpdateResponse response)
    {
        return new ProductCategoryUpdateDto(response.ProductId, response.CategoryId);
    }
}
