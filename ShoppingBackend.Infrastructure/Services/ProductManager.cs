using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Common.Models.Product;
using ShoppingBackend.Application.Features.Product.Commands.Add;
using ShoppingBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Infrastructure.Services;

public sealed class ProductManager:IProductService
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;

    public ProductManager(ICurrentUserService currentUserService, IApplicationDbContext context)
    {
        _currentUserService = currentUserService;
        _context = context;
    }

    public async Task<ProductAddResponse> ProductAdd(ProductAddCommand request, CancellationToken cancellationToken)
    {
        Product product = new()
        {
            Name = request.Name,
            StockAmount = request.StockAmount,
            CreatedByUserId = _currentUserService.UserId.ToString(),
            Code = request.Code,
            CreatedOn = DateTime.Now,
        };
        await _context.Product.AddAsync(product);
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return  new ProductAddResponse
            {
                Id = product.Id,
                Name = product.Name,
                StockAmount = product.StockAmount,
                Code=product.Code
            };
        }
        return null;

    }
}
