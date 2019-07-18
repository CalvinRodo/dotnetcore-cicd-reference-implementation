using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace DotnetcoreCicdReferenceImplementation
{

    ///<summary>
    /// Class used for the configuration of the app
    ///</summary>
    public class Startup
    {
        ///<summary>
        /// configuration of the application
        ///</summary>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }


        ///<summary>
        /// Injected configuration object
        ///</summary>
        public IConfiguration Configuration { get; }

        ///<summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        ///</summary>
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        ///<summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        ///</summary>
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
