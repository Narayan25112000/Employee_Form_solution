using Business_Layer.IService;
using Business_Layer.Service;
using Data.Data;
using Data.IData;
using DataService_Layer.Data;
using DataService_Layer.IData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Form
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

         services.AddCors(options =>
          {
            options.AddDefaultPolicy(
                builder =>
                {
                  builder.WithOrigins("https://localhost:44351", "http://localhost:4200")
                                          .AllowAnyHeader()
                                          .AllowAnyMethod();
                });
          });
         services.AddControllers();
         
         #region DataService_Layer
         services.AddScoped<IUserData, UserData>();
         services.AddScoped<IDesignData, DesignData>();
         services.AddScoped<IDeptData, DeptData>();
         #endregion

         #region Business_Layer
         services.AddScoped<IUserService, UserService>();
         services.AddScoped<IDeptService, DeptService>();
         services.AddScoped<IDesignService, DesignService>();
         #endregion

      //services.AddDbContext<Data_service>(context => context.UseSqlServer(Configuration.GetConnectionString("cn1")));
     
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(builder =>
            {
              builder
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
            });

      app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
