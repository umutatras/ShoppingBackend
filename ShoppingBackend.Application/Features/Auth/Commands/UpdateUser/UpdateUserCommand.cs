using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Common.Models.Identity;
using ShoppingBackend.Application.Features.Auth.Commands.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;

public sealed class UpdateUserCommand : IRequest<ResponseDto<bool>>
{
    public Guid UserId { get; set; }
    public string Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
  
}
