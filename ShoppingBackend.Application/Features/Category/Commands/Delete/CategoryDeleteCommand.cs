using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Category.Commands.Delete;

public sealed class CategoryDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
