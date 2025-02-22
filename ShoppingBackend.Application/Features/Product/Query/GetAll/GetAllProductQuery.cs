using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Query.GetAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Product.Query.GetAll;

public sealed record GetAllProductQuery : IRequest<ResponseDto<List<GetAllProductDto>>>
{
}
