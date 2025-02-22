using ShoppingBackend.Application.Common.Models.BasketItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Add;

public class BasketItemAddDto
{
    public int ProductId { get; set; }

    public int BasketId { get; set; }

    public int Quantity { get; set; }
    public BasketItemAddDto(int productId,int basketId,int quantity)
    {
        ProductId = productId;
        BasketId = basketId;
        Quantity = quantity;
    }
    public static BasketItemAddDto Create(BasketItemAddResponse response)
    {
        return new BasketItemAddDto(response.ProductId, response.BasketId, response.Quantity);
    }
}
