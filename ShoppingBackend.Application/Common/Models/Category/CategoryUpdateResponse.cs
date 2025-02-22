namespace ShoppingBackend.Application.Common.Models.Category;

public sealed class CategoryUpdateResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}
