using ShoppingBackend.Application.Common.Models.ProductCategory;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IProductCategoryService
{
    Task<ProductCategoryAddResponse> ProductCategoryAdd(ProductCategoryAddCommand request, CancellationToken cancellationToken);
}
