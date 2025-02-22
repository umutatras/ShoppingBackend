using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Common.Models.ProductCategory;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Add;
using ShoppingBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Infrastructure.Services;

public class ProductCategoryManager:IProductCategoryService
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
            return new ProductCategoryAddResponse { CategoryId=productCategory.CategoryId,ProductId=productCategory.ProductId };
        }
        return null;
    }
}
