using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EstateApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstateApp.Data.DatabaseContexts.AuthenticationDbContext
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
     public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options)
     {

     }
    }
}