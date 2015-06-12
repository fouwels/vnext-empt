using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.ConfigurationModel.UserSecrets;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace pls
{
    public class Startup
    {
		public IConfiguration Configuration { get; set; }
		public Startup(IHostingEnvironment env)
		{
			var conf = new Configuration();
			//conf.AddJsonFile("config.json");
			//if (env.IsEnvironment("Development"))
			//{
			//	conf.AddUserSecrets();
			//}
			Configuration = conf;
		}
		public void ConfigureServices(IServiceCollection services)
        {
			services.AddMvc();
			services.AddLogging();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
			loggerFactory.AddConsole(minLevel: LogLevel.Information);
			app.UseStaticFiles();
			app.UseMvc(); //attribute routing

			//app.UseMvc(routes =>
			//{
			//	routes.MapRoute(
			//	name: "default",
			//	template: "{controller}/{action}/{id?}", 
			//	defaults: new { controller = "", action = "" }
			//	);
			//});
		}
	}
}
