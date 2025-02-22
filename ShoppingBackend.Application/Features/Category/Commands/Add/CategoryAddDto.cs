using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Common.Models.Identity;
using ShoppingBackend.Application.Features.Auth.Commands.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
