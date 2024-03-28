using System.Security.Claims;

namespace RecipesShare.WebExtensions
{
    public static class ClaimsExtensions
    {
           public static string GetId(this ClaimsPrincipal user)
    {

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return user.FindFirst(ClaimTypes.NameIdentifier).Value;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    }
}
}
