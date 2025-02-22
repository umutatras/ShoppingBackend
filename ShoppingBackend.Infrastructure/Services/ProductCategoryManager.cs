using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Common.Models.ProductCategory;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Add;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Update;
using ShoppingBackend.Domain.Entities;

namespace ShoppingBackend.Infrastructure.Services;

public class ProductCategoryManager : IProductCategoryService
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    public ProductCategoryManager(IApplicationDbContext context, ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }

    public async Task<ProductCategoryAddResponse> ProductCategoryAdd(ProductCategoryAddCommand request, CancellationToken cancellationToken)
    {
        ProductCategory productCategory = new ProductCategory { CategoryId = request.CategoryId, CreatedByUserId = _currentUserService.UserId.ToString(), CreatedOn = DateTime.Now, ProductId = request.ProductId };
        await _context.ProductCategories.AddAsync(productCategory);
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new ProductCategoryAddResponse { CategoryId = productCategory.CategoryId, ProductId = productCategory.ProductId };
        }
        return null;
    }

    public async Task<ProductCategoryUpdateResponse> ProductCategoryUpdate(ProductCategoryUpdateCommand request, CancellationToken cancellationToken)
    {
        ProductCategory productCategory = await _context.ProductCategories.FindAsync(request.Id, cancellationToken);
        if (productCategory == null)
        {
            return null;
        }
       productCategory.CategoryId = request.CategoryId;
        productCategory.ModifiedOn = DateTime.Now;
        productCategory.ModifiedByUserId = _currentUserService.UserId.ToString();
        productCategory.ProductId = request.ProductId;    
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new ProductCategoryUpdateResponse { ProductId = productCategory.ProductId, CategoryId = productCategory.CategoryId };
        }
        return null;
    }
}
