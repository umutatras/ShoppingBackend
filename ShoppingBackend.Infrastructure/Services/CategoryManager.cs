using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using ShoppingBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Infrastructure.Services;

public class CategoryManager : ICategoryService
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    public CategoryManager(IApplicationDbContext context, ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }

    public async Task<CategoryAddResponse> CategoryAdd(CategoryAddCommand request, CancellationToken cancellationToken)
    {
        Category category = new()
        {
            Name = request.Name,
            CreatedByUserId = _currentUserService.UserId.ToString(),
            CreatedOn = DateTime.Now,
        };
        await _context.Categories.AddAsync(category);
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new CategoryAddResponse
            {
                Id = category.Id,
                Name = category.Name,               
            };
        }
        return null;
    }
}
