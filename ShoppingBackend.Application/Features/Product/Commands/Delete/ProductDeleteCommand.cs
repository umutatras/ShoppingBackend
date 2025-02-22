using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Product.Commands.Delete;

public sealed class ProductDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
