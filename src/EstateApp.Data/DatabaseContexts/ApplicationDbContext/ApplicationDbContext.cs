using Microsoft.EntityFrameworkCore;

namespace EstateApp.Data.DatabaseContexts.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
       {

       }
    } 
}