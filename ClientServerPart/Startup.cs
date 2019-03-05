using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClientServerPart.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientServerPart
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContent>(options => options.UseSqlServer(Configuration["Data:CleverHouseItems:ConnectionString"]));
            services.AddMvc();
            //The AddTransient method specifies that a new FakeItemRepository object should be created each time the IItemRepository interface is needed.

            //Here we should replace FakeItemRepo by real db classes.
            services.AddTransient<IItemRepository, EFItemRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();          
            app.UseStaticFiles();                     
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Item}/{action=List}/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
