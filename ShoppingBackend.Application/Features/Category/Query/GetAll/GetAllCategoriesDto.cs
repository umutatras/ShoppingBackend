namespace ShoppingBackend.Application.Features.Category.Query.GetAll;

public sealed record GetAllCategoriesDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public GetAllCategoriesDto(int id, string name)
    {
        Name = name;
        Id = id;
    }
    public GetAllCategoriesDto()
    {

    }
}
