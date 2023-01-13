using CarsSelling.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace CarsSelling
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
            services.AddDbContext<AppDbContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IMakeRepository, MakeRepository>();
            services.AddScoped<IFuelTypeRepository, FuelTypeRepository>();
            services.AddScoped<IBodyTypeRepository, BodyTypeRepository>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddLocalization();

            services.AddMvc().AddDataAnnotationsLocalization(opts =>
            {
                opts.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(Resource));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.Configure<RequestLocalizationOptions>(opts =>
            {
                var supported = new[]
                {
                        new CultureInfo("en-US"),
                        new CultureInfo("sr-Latn-BA"),
                        new CultureInfo("de-DE"),
                };
                opts.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture(culture: "en", uiCulture: "en-US");
                opts.SupportedCultures = supported;
                opts.SupportedUICultures = supported;
            });

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
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
            app.UseRequestLocalization();
            app.UseHttpsRedirection();
           
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            UserDataInitializer.InsertRoleData(roleManager);
            UserDataInitializer.InsertUserData(userManager);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
