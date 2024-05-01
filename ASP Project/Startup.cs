using ASP_Project.Data;
using ASP_Project.Data.Interfaces;
using ASP_Project.Data.Mocks;
using ASP_Project.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppContent>(options => options.UseMySql(_confString.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 26))));

            services.AddTransient<IFlower, FlowerRepository>();
            services.AddTransient<ICategory, CategoryRepository>();
            services.AddSingleton<IShoppingCart, ShoppingCartRepository>();
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();
        }
    }
}
