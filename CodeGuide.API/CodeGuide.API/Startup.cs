using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGuide.EF;
using CodeGuide.EF.DomainModels;
using CodeGuide.EF.Interfaces;
using CodeGuide.EF.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodeGuide.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            var connection = @"Server=DESKTOP-I5O0JTM\SQLEXPRESS;Database=TecBlogDB;Trusted_Connection=True;";
            services.AddDbContext<BlogContext>(opt => opt.UseSqlServer(connection));

            services.AddMvc(opt => opt.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IContextFactory, ContextFactory>();

            services.AddScoped<IPostRepository, PostRepository>();
            //services.AddScoped<ITreatmentService, TreatmentService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(c =>
            {
                c.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });

            app.UseMvc();
        }
    }
}
