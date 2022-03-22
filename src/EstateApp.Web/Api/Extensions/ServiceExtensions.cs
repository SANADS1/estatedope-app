using System;
using EstateApp.Data.DatabaseContexts.AuthenticationDbContext;
using EstateApp.Data.DatabaseContexts.ApplicationDbContext;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace EstateApp.Web.Api.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureDbContext( this IServiceCollection services, IConfiguration configuration)
			

        {


            
			var connString = configuration.GetConnectionString("AuthenticationConnection");

			services.AddDbContextPool<AuthenticationDbContext>(options =>
			   options.UseSqlServer(connString),

               sqlServerOptions => {
                   sqlServerOptions.MigrationsAssembly("EstateApp.Data")
                   

                }
            );

 

            var connStringAppli = configuration.GetConnectionString("ApplicationConnection ");

			services.AddDbContextPool<ApplicationDbContext>(options =>
			    options.UseSqlServer(connStringAppli),
                
                sqlServerOptions => {
                    sqlServerOptions.MigrationsAssembly("EstateApp.Data")
           
                }
            );


		}
	}

}
