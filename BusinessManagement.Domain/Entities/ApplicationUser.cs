using Microsoft.AspNetCore.Identity;

namespace BusinessManagement.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string UserName { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public string Role { get; set; } = "User";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}