using MediatR;
using Microsoft.EntityFrameworkCore;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Category.Query.GetAll;

public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, ResponseDto<List<GetAllCategoriesDto>>>
{
    private readonly ICategoryService _categoryService;
    public GetAllCategoriesQueryHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<ResponseDto<List<GetAllCategoriesDto>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var result = await _categoryService.GetAllCategories(request, cancellationToken);
        return new ResponseDto<List<GetAllCategoriesDto>> { Data = result, Success = true, Message = string.Empty, Errors = null };
    }
}