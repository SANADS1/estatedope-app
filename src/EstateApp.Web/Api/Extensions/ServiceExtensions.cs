using System;
using EstateApp.Data.DatabaseContexts.AuthenticationDbContext;
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
			options.UseSqlServer(connString));
		}
	}

}
