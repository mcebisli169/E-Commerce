using ETicaretSitesi.Context;
using ETicaretSitesi.Controllers;
using ETicaretSitesi.Models;
using ETicaretSitesi.RepositoryPattern.Base;
using ETicaretSitesi.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretSitesi
{
    public class Startup
    {
        readonly IConfiguration configuration;
        public Startup(IConfiguration _configuration) // json içindeki dosyayý kullanabilmek için Iconfig kullanýlmalý
        {
            configuration = _configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:Mssql"]));
            services.AddControllersWithViews();
            services.AddScoped<IRepository<Category>, Repository<Category>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
