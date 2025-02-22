using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Add;

public class ProductCategoryAddCommandHandle : IRequestHandler<ProductCategoryAddCommand, ResponseDto<ProductCategoryAddDto>>
{
    private readonly IProductCategoryService productCategoryService;

    public ProductCategoryAddCommandHandle(IProductCategoryService productCategoryService)
    {
        this.productCategoryService = productCategoryService;
    }


    public async Task<ResponseDto<ProductCategoryAddDto>> Handle(ProductCategoryAddCommand request, CancellationToken cancellationToken)
    {
        var result = await productCategoryService.ProductCategoryAdd(request, cancellationToken);

        return new ResponseDto<ProductCategoryAddDto>(ProductCategoryAddDto.Create(result), "BasketItem Add Successfuly");

    }

}