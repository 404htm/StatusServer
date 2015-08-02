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

namespace StatusServer.Web
{
	

	public class Startup
    {
		public IConfiguration Configuration { get; set; }

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseMvc();
			app.UseStaticFiles();
			

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
			// Add MVC services to the services container.
			services.AddMvc();

			services.AddSingleton(_ => Configuration);
		}


		public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
		{
            var configurationBuilder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
            .AddJsonFile("config.json")
			.AddEnvironmentVariables();

			Configuration = configurationBuilder.Build();
			//.AddJsonFile($"config.{env.EnvironmentName}.json", optional: true);

			if (env.IsEnvironment("Development"))
			{
				// This reads the configuration keys from the secret store.
				// For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
				//configuration.AddUserSecrets();
			}
		
		}

		
	}
}
