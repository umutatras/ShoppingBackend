using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Category.Commands.Add;

public sealed class CategoryAddCommand : IRequest<ResponseDto<CategoryAddDto>>
{
    public string Name { get; set; } = null!;
}
