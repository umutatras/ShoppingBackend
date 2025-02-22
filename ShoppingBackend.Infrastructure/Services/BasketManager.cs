using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.Basket;
using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using ShoppingBackend.Application.Features.Basket.Commands.Update;
using ShoppingBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Infrastructure.Services;

public sealed class BasketManager : IBasketService
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    public BasketManager(IApplicationDbContext context, ICurrentUserService currentUserService)
    {
        _context = context;
        _currentUserService = currentUserService;
    }

    public async Task<BasketAddResponse> BasketAdd(BasketAddCommand request, CancellationToken cancellationToken)
    {
        Basket basket = new Basket
        {
            CreatedByUserId = _currentUserService.UserId.ToString(),
            CreatedOn = DateTime.Now,
            UserId = Guid.Parse(request.UserId)
        };
        await _context.Baskets.AddAsync(basket);
        int etkilenenSatir= await _context.SaveChangesAsync(cancellationToken);
        if(etkilenenSatir > 0)
        {
            return new BasketAddResponse
            {
                Id = basket.Id,
                UserId = basket.UserId.ToString()
            };
        }
        return null;
    }

    public async Task<BasketUpdateResponse> BasketUpdate(BasketUpdateCommand request, CancellationToken cancellationToken)
    {
        Basket basket = await _context.Baskets.FindAsync(request.Id, cancellationToken);
        if (basket == null)
        {
            return null;
        }
        basket.UserId = Guid.Parse(request.UserId);
        basket.ModifiedByUserId = _currentUserService.UserId.ToString();
        basket.ModifiedOn = DateTime.Now;
        int etkilenenSatir = await _context.SaveChangesAsync(cancellationToken);
        if (etkilenenSatir > 0)
        {
            return new BasketUpdateResponse
            {
                Id = basket.Id,
                UserId = basket.UserId.ToString(),
            };
        }
        return null;
    }
}
