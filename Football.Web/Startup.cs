////using System;
////using System.Collections.Generic;
////using System.Globalization;
////using System.Linq;
////using System.Threading.Tasks;
////using Football.Data;
////using Football.Model.Entities;
////using Football.Web.Mappings;
////using Microsoft.AspNetCore.Builder;
////using Microsoft.AspNetCore.Hosting;
////using Microsoft.AspNetCore.HttpsPolicy;
////using Microsoft.AspNetCore.Identity;
////using Microsoft.AspNetCore.Localization;
////using Microsoft.Extensions.Configuration;
////using Microsoft.Extensions.DependencyInjection;
////using Microsoft.Extensions.Hosting;


//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Localization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Razor;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Football.Data;
//using Football.Data.Abstract;
//using Football.Data.InitialData;
//using Football.Data.Persistence;
//using Football.Model.Entities;
//using Football.Web.Mappings;
//using Football.Web.Services.Profile;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using Football.Web.Services;
//using Microsoft.Extensions.Hosting;

//namespace Football.Web
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {
//            // Automapper Configuration
//            //AutoMapperConfiguration.Configure();

//            //var supportedCultures = new[]
//            //{
//            //    new CultureInfo("es-MX"),
//            //    new CultureInfo("en-GB")
//            //};

//            //services.Configure<RequestLocalizationOptions>(options =>
//            //{
//            //    options.SupportedCultures = supportedCultures;
//            //    options.SupportedUICultures = supportedCultures;
//            //    options.DefaultRequestCulture = new RequestCulture("es-MX", "es-MX");
//            //    options.RequestCultureProviders = new List<IRequestCultureProvider>
//            //    {
//            //        new CookieRequestCultureProvider()
//            //    };
//            //});


//            //services.AddControllersWithViews();
//            services.Configure<CookiePolicyOptions>(options =>
//            {
//                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
//                options.CheckConsentNeeded = context => true;
//                options.MinimumSameSitePolicy = SameSiteMode.None;
//            });

//            services.Configure<CookieTempDataProviderOptions>(options =>
//            {
//                options.Cookie.IsEssential = true;
//            });

//            services.AddDbContext<ApplicationContext>(options =>
//                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
//                    b => b.MigrationsAssembly("Football.Data")));

//            services.AddScoped<IUnitOfWork, UnitOfWork>();

//            // Automapper Configuration
//            AutoMapperConfiguration.Configure();

//            services.AddDefaultIdentity<ApplicationUser>(config =>
//            {
//                config.User.RequireUniqueEmail = true;    // уникальный email
//                config.User.AllowedUserNameCharacters = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789 -._@+бйнуъáéíóú";
//                config.SignIn.RequireConfirmedEmail = true;
//            })
//                .AddRoles<ApplicationRole>()
//                .AddEntityFrameworkStores<ApplicationContext>()
//                .AddDefaultTokenProviders();

//            var supportedCultures = new[]
//            {
//                new CultureInfo("es-MX"),
//                new CultureInfo("en-GB")
//            };

//            services.Configure<RequestLocalizationOptions>(options =>
//            {
//                options.SupportedCultures = supportedCultures;
//                options.SupportedUICultures = supportedCultures;
//                options.DefaultRequestCulture = new RequestCulture("es-MX", "es-MX");
//                options.RequestCultureProviders = new List<IRequestCultureProvider>
//                {
//                    new CookieRequestCultureProvider()
//                };
//            });

//            services.ConfigureApplicationCookie(x =>
//            {
//                x.ExpireTimeSpan = TimeSpan.FromDays(5);
//            });

//            services.AddSignalR();

//            services.AddMvc()
//                .SetCompatibilityVersion(CompatibilityVersion.Latest)
//                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
//                .AddDataAnnotationsLocalization(options =>
//                {
//                    options.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(SharedResources));
//                });

//            services.AddHsts(options =>
//            {
//                options.Preload = true;
//                options.IncludeSubDomains = true;
//                options.MaxAge = TimeSpan.FromDays(60);
//            });

//            services.AddLocalization(options => options.ResourcesPath = "Resources");

//            //services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
//            //services.AddSingleton<IEmailSender, EmailSender>();


//            services.AddScoped<ProfileManager>();



//            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
//        }

//        //// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        //{
//        //    if (env.IsDevelopment())
//        //    {
//        //        app.UseDeveloperExceptionPage();
//        //    }
//        //    else
//        //    {
//        //        app.UseExceptionHandler("/Home/Error");
//        //        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//        //        app.UseHsts();
//        //    }
//        //    app.UseHttpsRedirection();
//        //    app.UseStaticFiles();

//        //    app.UseRouting();

//        //    app.UseAuthorization();

//        //    app.UseEndpoints(endpoints =>
//        //    {
//        //        endpoints.MapControllerRoute(
//        //            name: "default",
//        //            pattern: "{controller=Home}/{action=Index}/{id?}");
//        //    });
//        //}

//        //public void Configure(
//        //    IApplicationBuilder app,
//        //    IWebHostEnvironment env,
//        //    UserManager<ApplicationUser> userManager,
//        //    RoleManager<ApplicationRole> roleManager,
//        //    ApplicationContext context)
//        //{
//        //    if (env.IsDevelopment())
//        //    {
//        //        app.UseDeveloperExceptionPage();
//        //        app.UseDatabaseErrorPage();
//        //    }
//        //    else
//        //    {
//        //        app.UseExceptionHandler("/Home/Error");
//        //        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//        //        app.UseHsts();
//        //    }

//        //    app.UseHttpsRedirection();
//        //    app.UseStaticFiles();
//        //    app.UseCookiePolicy();

//        //    app.UseAuthentication();

//        //    app.UseRequestLocalization();

//        //    //DataInitializer.SeedData(userManager, roleManager, new UnitOfWork(context));
//        //    var applicationBuilder = app.UseMvc(routes =>
//        //    {
//        //        routes.MapRoute(
//        //            name: "default",
//        //            template: "{controller=Home}/{action=Index}/{id?}");
//        //    });
//        //}
//        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
//            else
//            {
//                app.UseExceptionHandler("/Home/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//            }

//            app.UseHttpsRedirection();
//            app.UseStaticFiles();
//            app.UseCookiePolicy();

//            app.UseMvc(routes =>
//            {
//                routes.MapRoute(
//                    name: "default",
//                    template: "{controller=Home}/{action=Index}/{id?}");
//            });
//        }
//    }
//}


using Football.Web.Services.Profile;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Football.Web
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

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            //services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            //services.AddSingleton<IEmailSender, EmailSender>();

            //services.AddScoped<ProfileManager>();

            services.AddMvc(options => options.EnableEndpointRouting = false);

            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
