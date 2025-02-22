using Microsoft.EntityFrameworkCore;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.Basket;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using ShoppingBackend.Application.Features.BasketItem.Commands.Delete;
using ShoppingBackend.Application.Features.BasketItem.Commands.Update;
using ShoppingBackend.Application.Features.BasketItem.Query.GetAll;
using ShoppingBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Infrastructure.Services;

public class BasketItemManager : IBasketItemService
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    public BasketItemManager(IApplicationDbContext context, ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }

    public async Task<List<BasketItemGetAllDto>> BasketGetAll(GetallBasketItemQuery request, CancellationToken cancellationToken)
    {
        var basketItems = await _context.BasketItems.Include(x => x.Product).Include(x => x.Basket).Select(x => new BasketItemGetAllDto { BasketId = x.BasketId, ProductAmount = x.Product.StockAmount, ProductId = x.ProductId, Quantity = x.Quantity, ProductName = x.Product.Name }).ToListAsync(cancellationToken);
        return basketItems;
    }

    public async Task<BasketItemAddResponse> BasketItemAdd(BasketItemAddCommand request, CancellationToken cancellationToken)
    {
        BasketItem basketItem = new BasketItem { BasketId = request.BasketId, CreatedByUserId = _currentUserService.UserId.ToString(), CreatedOn = DateTime.Now, ProductId = request.ProductId, Quantity = request.Quantity };
        await _context.BasketItems.AddAsync(basketItem);
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new BasketItemAddResponse { BasketId = basketItem.BasketId, ProductId = basketItem.ProductId, Quantity = basketItem.Quantity };
        }
        return null;
    }

    public async Task<bool> BasketItemDelete(BasketItemDeleteCommand request, CancellationToken cancellationToken)
    {
        BasketItem basketItem = await _context.BasketItems.FindAsync(request.Id, cancellationToken);
        if (basketItem == null)
        {
            return false;
        }
        _context.BasketItems.Remove(basketItem);
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return true;
        }
        return false;
    }

    public async Task<BasketItemUpdateResponse> BasketItemUpdate(BasketItemUpdateCommand request, CancellationToken cancellationToken)
    {
        BasketItem basketItem = await _context.BasketItems.FindAsync(request.Id, cancellationToken);
        if (basketItem == null)
        {
            return null;
        }
        basketItem.Quantity = request.Quantity;
        basketItem.ProductId = request.ProductId;
        basketItem.BasketId = request.BasketId;
        basketItem.ModifiedByUserId = _currentUserService.UserId.ToString();
        basketItem.ModifiedOn = DateTime.Now;
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new BasketItemUpdateResponse { Id = basketItem.Id, BasketId = basketItem.BasketId, ProductId = basketItem.ProductId, Quantity = basketItem.Quantity };
        }
        return null;
    }
}
