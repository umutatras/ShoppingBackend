using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Category.Commands.Delete;

public sealed class CategoryDeleteCommandHandle : IRequestHandler<CategoryDeleteCommand, ResponseDto<bool>>
{
    private readonly ICategoryService _categoryService;

    public CategoryDeleteCommandHandle(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    public async Task<ResponseDto<bool>> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        var result = await _categoryService.CategoryDelete(request, cancellationToken);

        return new ResponseDto<bool>(result, "Category Deleted Successfuly");

    }

}