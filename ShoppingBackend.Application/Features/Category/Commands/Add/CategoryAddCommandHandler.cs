using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Category.Commands.Add;

public sealed class CategoryAddCommandHandler : IRequestHandler<CategoryAddCommand, ResponseDto<CategoryAddDto>>
{
    private readonly ICategoryService _categoryService;

    public CategoryAddCommandHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    public async Task<ResponseDto<CategoryAddDto>> Handle(CategoryAddCommand request, CancellationToken cancellationToken)
    {
        var result= await _categoryService.CategoryAdd(request, cancellationToken);   

        return new ResponseDto<CategoryAddDto>(CategoryAddDto.Create(result), "Category Add Successfuly");

    }

}