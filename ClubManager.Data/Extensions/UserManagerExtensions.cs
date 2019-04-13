using ClubManager.Data.Entity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Security.Claims;

namespace ClubManager.Data.Extensions
{
    public static class UserManagerExtensions
    {
        public static string GetUserFirstname(this UserManager<IdentityUser> um, ClaimsPrincipal User)
        {
            return um?.Users?.FirstOrDefault(x => x.UserName == User.Identity.Name).UserName;
        }
    }

    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserId(this ClaimsPrincipal principal) =>
            principal.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
