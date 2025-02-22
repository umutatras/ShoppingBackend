using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Add;

public class ProductCategoryAddCommand:IRequest<ResponseDto<ProductCategoryAddDto>>
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
}
