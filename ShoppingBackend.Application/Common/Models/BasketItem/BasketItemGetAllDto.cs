using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Common.Models.BasketItem;

public sealed record BasketItemGetAllDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public int ProductAmount { get; set; }
    public int BasketId { get; set; }
    public BasketItemGetAllDto(int productId,string productName,int quantity,int productAmount,int basketId)
    {
        ProductId = productId;
        ProductAmount = productAmount;
        Quantity = quantity;
        BasketId = basketId;
        ProductName = productName;
    }
    public BasketItemGetAllDto()
    {
        
    }
}
