using Microsoft.EntityFrameworkCore;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using ShoppingBackend.Application.Features.Category.Commands.Delete;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using ShoppingBackend.Application.Features.Category.Query.GetAll;
using ShoppingBackend.Domain.Entities;

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

    public async Task<bool> CategoryDelete(CategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        Category category = await _context.Categories.FindAsync(request.Id, cancellationToken);
        if (category == null)
        {
            return false;
        }
        _context.Categories.Remove(category);
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return true;
        }
        return false;
    }

    public async Task<CategoryUpdateResponse> CategoryUpdate(CategoryUpdateCommand request, CancellationToken cancellationToken)
    {
        Category category = await _context.Categories.FindAsync(request.Id , cancellationToken);
        if (category == null)
        {
            return null;
        }
        category.Name = request.Name;
        category.ModifiedByUserId = _currentUserService.UserId.ToString();
        category.ModifiedOn = DateTime.Now;
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new CategoryUpdateResponse
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
        return null;
    }

    public async Task<List<GetAllCategoriesDto>> GetAllCategories(GetAllCategoriesQuery query, CancellationToken cancellationToken)
    {
        List<GetAllCategoriesDto> categories = await _context.Categories
            .Select(x => new GetAllCategoriesDto { Id = x.Id, Name = x.Name })
            .ToListAsync(cancellationToken);
        return categories;
    }
}
