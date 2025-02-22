using Microsoft.EntityFrameworkCore;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Common.Models.Product;
using ShoppingBackend.Application.Features.Product.Commands.Add;
using ShoppingBackend.Application.Features.Product.Commands.Delete;
using ShoppingBackend.Application.Features.Product.Commands.Update;
using ShoppingBackend.Application.Features.Product.Query.GetAll;
using ShoppingBackend.Domain.Entities;

namespace ShoppingBackend.Infrastructure.Services;

public sealed class ProductManager : IProductService
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;

    public ProductManager(ICurrentUserService currentUserService, IApplicationDbContext context)
    {
        _currentUserService = currentUserService;
        _context = context;
    }

    public async Task<List<GetAllProductDto>> GetAllProducts(GetAllProductQuery query, CancellationToken cancellationToken)
    {
        var products = await _context.Product.Select(x => new GetAllProductDto
        {
            Id = x.Id,
            Name = x.Name,
            StockAmount = x.StockAmount,
            Code = x.Code,
            Categories = x.ProductCategories.Select(x => new ProductCategories
            {
                Id = x.CategoryId,
                Name = x.Category.Name
            }).ToList()
        }
            ).ToListAsync();
        return products;
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
            return new ProductAddResponse
            {
                Id = product.Id,
                Name = product.Name,
                StockAmount = product.StockAmount,
                Code = product.Code
            };
        }
        return null;

    }

    public async Task<bool> ProductDelete(ProductDeleteCommand request, CancellationToken cancellationToken)
    {
        Product product = await _context.Product.FindAsync(request.Id, cancellationToken);
        if (product == null)
        {
            return false;
        }
        _context.Product.Remove(product);
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return true;
        }
        return false;
    }

    public async Task<ProductUpdateResponse> ProductUpdate(ProductUpdateCommand request, CancellationToken cancellationToken)
    {
        Product product = await _context.Product.FindAsync(request.Id, cancellationToken);
        if (product == null)
        {
            return null;
        }
        product.Name = request.Name;
        product.StockAmount = request.StockAmount;
        product.Code = request.Code;
        product.ModifiedByUserId = _currentUserService.UserId.ToString();
        product.ModifiedOn = DateTime.Now;
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new ProductUpdateResponse
            {
                Id = product.Id,
                Name = product.Name,
                StockAmount = product.StockAmount,
                Code = product.Code
            };
        }
        return null;
    }
}
