using ShoppingBackend.Application.Common.Models.Category;

namespace ShoppingBackend.Application.Features.Category.Commands.Add;

public sealed class CategoryAddDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public CategoryAddDto(int id, string Name)
    {
        Id = id;
        Name = Name;
    }

    public static CategoryAddDto Create(CategoryAddResponse response)
    {
        return new CategoryAddDto(response.Id, response.Name);
    }
}
