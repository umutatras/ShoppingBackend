using ShoppingBackend.Application.Common.Interfaces;
using System.Security.Claims;

namespace ShoppingBackend.WebAPI.Services;

public class CurrentUserManager : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IWebHostEnvironment _env;
    public CurrentUserManager(IHttpContextAccessor contextAccessor, IWebHostEnvironment webHostEnvironment)
    {
        _httpContextAccessor = contextAccessor;
        _env = webHostEnvironment;
    }

    public Guid UserId => GetUserId();


    private Guid GetUserId()
    {
        var userId = _httpContextAccessor
            .HttpContext?
            .User?
            .FindFirstValue("uid");

        return string.IsNullOrEmpty(userId) ? Guid.Empty : Guid.Parse(userId);
    }


}
