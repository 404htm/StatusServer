using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Framework.Configuration;
using Microsoft.Framework.Configuration.Json;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Runtime;

using Microsoft.AspNet.Identity;

using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.Diagnostics.Entity;
using StatusServer.Web.Identity;
using Microsoft.Framework.Logging;

namespace StatusServer.Web
{
	

	public class Startup
    {
		public IConfiguration Configuration { get; set; }
		public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
		{
			var builder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
			.AddJsonFile("config.json")
			.AddJsonFile($"config.{env.EnvironmentName}.json", optional: true)
			.AddEnvironmentVariables();

			if (env.IsEnvironment("Development"))
			{
				builder.AddUserSecrets();
			}

			builder.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{

			if (env.IsDevelopment())
			{
				app.UseBrowserLink();
				app.UseErrorPage(ErrorPageOptions.ShowAll);
				app.UseDatabaseErrorPage(DatabaseErrorPageOptions.ShowAll);
			}
			else
			{
				// Add Error handling middleware which catches all application specific errors and
				// sends the request to the following path or controller action.
				app.UseErrorHandler("/Home/Error");
			}

			app.UseMvc();
			app.UseStaticFiles();
			app.UseIdentity();

			app.UseMvc(routes =>
			{
				routes
				.MapRoute(
						name: "fullscreen",
						template: "fs/{controller}/{action}/{id?}",
						defaults: new { controller = "Home", action = "Index", fullscreen=true })
				.MapRoute(
						name: "default",
						template: "{controller}/{action}/{id?}",
						defaults: new { controller = "Home", action = "Index", fullscreen=false })
					;
			});
		}

		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
        {
			
			services.AddIdentity<AppIdentityUser, AppRole>()
				.AddUserManager<UserManager<AppIdentityUser>>()
				.AddDefaultTokenProviders();

			services.AddMvc();
			//services.AddTransient<IEmailSender, AuthMessageSender>();
			//services.AddTransient<ISmsSender, AuthMessageSender>();
			services.AddSingleton(_ => Configuration);
		}



		
	}
}
