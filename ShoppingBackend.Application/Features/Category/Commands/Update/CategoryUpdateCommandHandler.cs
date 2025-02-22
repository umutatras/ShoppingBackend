using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Category.Commands.Update;

public sealed class CategoryUpdateCommandHandler : IRequestHandler<CategoryUpdateCommand, ResponseDto<CategoryUpdateDto>>
{
    private readonly ICategoryService _categoryService;

    public CategoryUpdateCommandHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    public async Task<ResponseDto<CategoryUpdateDto>> Handle(CategoryUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _categoryService.CategoryUpdate(request, cancellationToken);

        return new ResponseDto<CategoryUpdateDto>(CategoryUpdateDto.Update(result), "Category Add Successfuly");

    }

}