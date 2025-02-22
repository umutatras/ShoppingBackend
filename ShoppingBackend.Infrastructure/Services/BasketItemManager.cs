using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
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
}
