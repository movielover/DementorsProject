using Dementors.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Dementors
{
	public class Startup
	{
		private readonly IConfigurationRoot configuration;
		
		public Startup(IHostingEnvironment env)
		{
			configuration = new ConfigurationBuilder()
				.AddEnvironmentVariables()
				.AddJsonFile(env.ContentRootPath + "/config.json")
				.Build();
		}
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<DbContext>(options =>
			{
				var connectionString = configuration.GetConnectionString("DbContext")
				options.UseSqlServer(connectionString);

			});
			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
				
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseMvc(routes =>
			{
				routes.MapRoute("Default", "{controller=Home}/{action=index}/{id:int?}");
			});
			app.UseFileServer();
		}
	}
}
