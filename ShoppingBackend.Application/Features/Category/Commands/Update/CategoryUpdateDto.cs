using ShoppingBackend.Application.Common.Models.Category;

namespace ShoppingBackend.Application.Features.Category.Commands.Update;

public sealed class CategoryUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public CategoryUpdateDto(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public static CategoryUpdateDto Update(CategoryUpdateResponse response)
    {
        return new CategoryUpdateDto(response.Id, response.Name);
    }
}
