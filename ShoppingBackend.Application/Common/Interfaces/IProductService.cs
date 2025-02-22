using ShoppingBackend.Application.Common.Models.Product;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using ShoppingBackend.Application.Features.Category.Commands.Delete;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using ShoppingBackend.Application.Features.Category.Query.GetAll;
using ShoppingBackend.Application.Features.Product.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IProductService
{
    Task<ProductAddResponse> ProductAdd(ProductAddCommand request, CancellationToken cancellationToken);
    //Task<ProductUpdateResponse> ProductUpdate(ProductUpdateCommand request, CancellationToken cancellationToken);
    //Task<bool> ProductDelete(ProductDeleteCommand request, CancellationToken cancellationToken);
    //Task<List<GetAllProductsDto>> GetAllProducts(GetAllProductsQuery query, CancellationToken cancellationToken);
}
