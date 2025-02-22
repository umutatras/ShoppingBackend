using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Common.Models.Identity;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface ICategoryService
{
    Task<CategoryAddResponse> CategoryAdd(CategoryAddCommand request, CancellationToken cancellationToken);
}
