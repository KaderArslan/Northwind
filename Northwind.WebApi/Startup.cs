using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Northwind.Bll;
using Northwind.Dal.Abstract;
using Northwind.Dal.Concrete.Entityframework.Context;
using Northwind.Dal.Concrete.Entityframework.Repository;
using Northwind.Dal.Concrete.Entityframework.UnitOfWork;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region JwtTokenService
            #endregion

            #region ApplicationContext
            services.AddDbContext<NORTHWNDContext>();
            services.AddScoped<DbContext, NORTHWNDContext>();
            #endregion


            #region ServiceSection
            services.AddScoped<ICustomerService, CustomerManager>();
            #endregion

            #region RepositorySection
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            #endregion

            #region UnitOfWork
            services.AddScoped<IUnitofWork, UnitOfWork>();
            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Northwind.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Northwind.WebApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
