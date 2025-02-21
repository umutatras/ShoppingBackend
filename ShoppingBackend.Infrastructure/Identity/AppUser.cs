using Microsoft.AspNetCore.Identity;
using ShoppingBackend.Domain.Common;

namespace ShoppingBackend.Infrastructure.Identity;

public sealed class AppUser : IdentityUser<Guid>, IEntity<Guid>, ICreatedByEntity, IModifiedByEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTimeOffset? ModifiedOn { get; set; }
    public string? ModifiedByUserId { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
    public string CreatedByUserId { get; set; }
}
