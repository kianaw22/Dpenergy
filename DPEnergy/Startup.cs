using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.CommonLayer.Services;
using DPEnergy.DataModelLayer;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Repository;
using DPEnergy.DataModelLayer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DPEnergy
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //handle timeout

            //DataBaseService
            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.EnableDetailedErrors(true);
                option.UseSqlServer(Configuration.GetConnectionString("DpenergyConnectionString"),
                   datamodel => datamodel.MigrationsAssembly("DPEnergy.DataModelLayer")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); ;

            });

            //Identity Service
            services.AddIdentity<A_UserManager, ApplicationRoles>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();


            services.Configure<KestrelServerOptions>(options =>
            {

                options.AllowSynchronousIO = true;
            });
            services.Configure<IISServerOptions>(options =>
            {

                options.AllowSynchronousIO = true;
            });
            services.AddSignalR();

            services.AddScoped<IUploadFiles, UploadFiles>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAccessRepository, AccessRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddAutoMapper(typeof(Startup));

            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "AspNetCore.Identity.Application";
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.SlidingExpiration = true;
                options.Cookie.IsEssential = true;
            });
            services.AddDataProtection()
                .SetApplicationName($"dpenergy-{Environment.EnvironmentName}")
                .PersistKeysToFileSystem(new DirectoryInfo($@"{Environment.ContentRootPath}\keys"));
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromHours(1);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthentication(); // Access to pages 
            app.UseAuthorization();  // Access to Information


            app.UseEndpoints(endpoints =>
            {
                //AdminArea
                endpoints.MapAreaControllerRoute(
                    "AdminArea",
                    "AdminArea",
                    "AdminArea/{controller=UserManager}/{action=Index}/{id?}");
                
                //UserArea
                endpoints.MapAreaControllerRoute(
                   "UserArea",
                   "UserArea",
                   "UserArea/{controller=UserHome}/{action=Index}/{id?}");
                //DMSArea
                endpoints.MapAreaControllerRoute(
                   "DMSArea",
                   "DMSArea",
                   "DMSArea/{controller=Home}/{action=Index}/{id?}");
                //TimesheetArea
                endpoints.MapAreaControllerRoute(
                 "TimeSheetArea",
                 "TimeSheetArea",
                 "TimeSheetArea/{controller=Home}/{action=Index}/{id?}");
                //DabirArea
                endpoints.MapAreaControllerRoute(
                 "DabirArea",
                 "DabirArea",
                 "DabirArea/{controller=Home}/{action=Index}/{id?}");
                //PersonelArea
                endpoints.MapAreaControllerRoute(
                 "PersonelArea",
                 "PersonelArea",
                 "PersonelArea/{controller=Home}/{action=Index}/{id?}");
                //default
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
