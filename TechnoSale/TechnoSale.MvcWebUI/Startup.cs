﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TechnoSale.Business.Abstract;
using TechnoSale.Business.Concrete;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.DataAccess.Concrete.EntityFramework;
using TechnoSale.MvcWebUI.Entities;
using TechnoSale.MvcWebUI.Middlewares;
using TechnoSale.MvcWebUI.Services;

namespace TechnoSale.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUrunService, UrunManager>();
            services.AddScoped<IUrunDal, EfUrunDal>();
            services.AddScoped<IKampanyaService, KampanyaManager>();
            services.AddScoped<IKampanyaDal, EfKampanyaDal>();
            services.AddScoped<IKategoriService, KategoriManager>();
            services.AddScoped<IKategoriDal, EfKategoriDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<ICartService, CartService>();
            services.AddDbContext<CustomIdentityDbContext>
            (options => options.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=alisveris;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            app.UseIdentity();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
        }
    }
}
