using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Query.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Product.Query.GetAll;

public sealed class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ResponseDto<List<GetAllProductDto>>>
{
    private readonly IProductService _productService;
    public GetAllProductQueryHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<ResponseDto<List<GetAllProductDto>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var result = await _productService.GetAllProducts(request, cancellationToken);
        return new ResponseDto<List<GetAllProductDto>> { Data = result, Success = true, Message = string.Empty, Errors = null };
    }
}