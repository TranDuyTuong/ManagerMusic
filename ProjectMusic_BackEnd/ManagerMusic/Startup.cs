using DataApplication.ApplicationAdmin.ApplicationAddress.Address_App;
using DataApplication.ApplicationAdmin.ApplicationMusic.Music_App;
using DataApplication.ApplicationAdmin.ApplicationPlans.Plan_app;
using DataApplication.ApplicationAdmin.ApplicationReports.Reports_app;
using DataApplication.ApplicationAdmin.ApplicationRequestUser.RequestUser_app;
using DataApplication.ApplicationAdmin.ApplicationRole.Role_app;
using DataApplication.ApplicationAdmin.ApplicationSaints.Saint_App;
using DataApplication.ApplicationAdmin.ApplicationSeason.Season_App;
using DataApplication.ApplicationAdmin.ApplicationStaff.Staff_App;
using DataApplication.ApplicationAdmin.ApplicationUsers.Users_App;
using DataApplication.ApplicationUser.ApplicationAddress.AddressUser;
using DataApplication.ApplicationUser.ApplicationBuildSoftware.BuildSoftwareUser;
using DataApplication.ApplicationUser.ApplicationHome.HomeClient;
using DataApplication.ApplicationUser.ApplicationHome.MusicClient;
using DataApplication.ApplicationUser.ApplicationHome.SaintClient;
using DataApplication.ApplicationUser.ApplicationHome.SeasonClient;
using DataApplication.ApplicationUser.ApplicationNotification;
using DataApplication.ApplicationUser.ApplicationSignin.SignInUser;
using DataMigration.DataEF;
using DataService.ServiceAdmin.Address;
using DataService.ServiceAdmin.Comment_Answer;
using DataService.ServiceAdmin.Music;
using DataService.ServiceAdmin.Plans;
using DataService.ServiceAdmin.Ratings;
using DataService.ServiceAdmin.Reports;
using DataService.ServiceAdmin.RequestUser;
using DataService.ServiceAdmin.Role;
using DataService.ServiceAdmin.Saint;
using DataService.ServiceAdmin.Season;
using DataService.ServiceAdmin.User;
using DataService.ServiceUser.Address;
using DataService.ServiceUser.BuildSoftwareClient;
using DataService.ServiceUser.HomeClient;
using DataService.ServiceUser.LoginAndRegiter;
using DataService.ServiceUser.MusicClient;
using DataService.ServiceUser.NotificatonUser;
using DataService.ServiceUser.SaintClient;
using DataService.ServiceUser.SeasonClient;
using DataTable.Table.Role;
using DataTable.Table.User;
using ManagerMusic.AuthorizeRole;
using ManagerMusic.Hubs;
using ManagerMusic.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Security.Claims;

namespace ManagerMusic
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
            //call connectionstring database
            services.AddDbContext<ContextDB>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ManagerMusicDatabase")));

            services.AddIdentity<T_User, T_Role>()
                .AddEntityFrameworkStores<ContextDB>()
                .AddDefaultTokenProviders();

            //Authorize Role
            services.AddAuthorization(config =>
            {
                config.AddPolicy("UserPolicy", policyBuilder =>
                {
                    policyBuilder.UserRequireCustomClaim(ClaimTypes.Email);
                    policyBuilder.UserRequireCustomClaim(ClaimTypes.DateOfBirth);
                });
            });
            services.AddScoped<IAuthorizationHandler, PoliciesAuthorizationHandler>();
            services.AddScoped<IAuthorizationHandler, RolesAuthorizationHandler>();

            //DI
            //Application Admin
            services.AddTransient<ImusicApplication, MusciApplication>();
            services.AddTransient<IUserRegiter_App, UserRegiter_App>();
            services.AddTransient<IUserAddress_App, UserAddress_App>();
            services.AddTransient<IuserLogin_App, UserLogin_App>();
            services.AddTransient<INotificationUser_App, NotificationUser_App>();
            services.AddTransient<ISaint_App, Saint_App>();
            services.AddTransient<Irole_App, Role_App>();
            services.AddTransient<Istaff_app, Staff_app>();
            services.AddTransient<ISeason_App, Season_App>();
            services.AddTransient<Iplan_App, Plan_App>();
            services.AddTransient<Iusers_app, User_app>();
            services.AddTransient<Ireport_App, Report_App>();
            services.AddTransient<IrequestUser_App, RequestUser_App>();
            services.AddTransient<IaddressApplication, AddressApplication>();
            //Application Client
            services.AddTransient<IhomeClient_App, HomeClient_App>();
            services.AddTransient<ImusicClient_App, MusicClient_App>();
            services.AddTransient<IseasonClient_App, SeasonClient_App>();
            services.AddTransient<IsaintClient_App, SaintClient_App>();
            services.AddTransient<IbuildSoftware_App, BuildSoftware_App>();

            //Service Admin
            services.AddTransient<Iserivce_Music, Serivce_Music>();
            services.AddTransient<IregiterUser, RegiterUser>();
            services.AddTransient<IUserAddress, UserAddress>();
            services.AddTransient<IloginUser, loginUser>();
            services.AddTransient<INotificationUser, NotificationUser>();
            services.AddTransient<IUser, Users>();
            services.AddTransient<Iservice_Saint, Service_Saint>();
            services.AddTransient<Iservice_Role, Service_Role>();
            services.AddTransient<Icomment_Answer, Comment_Answer>();
            services.AddTransient<Irating_Service, Rating_Service>();
            services.AddTransient<Iservice_Season, Service_Season>();
            services.AddTransient<Iservice_Plans, Service_Plans>();
            services.AddTransient<Iservice_Reports, Service_Reports>();
            services.AddTransient<Isevice_RequestUser, Sevice_RequestUser>();
            services.AddTransient<Iservice_Citys, Service_Citys>();
            //Service Client
            services.AddTransient<IhomeClient, HomeClient>();
            services.AddTransient<ImusicClient, MusicClient>();
            services.AddTransient<IseasonClient, SeasonClient>();
            services.AddTransient<IsaintClient, SaintClient>();
            services.AddTransient<IbuildSoftware, BuildSoftware>();

            //cookie login authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.Name = "LoginManagerMusic";
                    options.ExpireTimeSpan = TimeSpan.FromHours(1);
                    options.LoginPath = new PathString("/Account/IndexLogin");
                    options.AccessDeniedPath = "/Account/AccessDenied/";
                    options.SlidingExpiration = true;
                });

            //RazorRunTime
            services.AddRazorPages().AddRazorRuntimeCompilation();

            //chat
            services.AddSignalR();
            services.AddControllersWithViews();

            //translation
            services.AddSingleton<LanguageService>();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
                    .AddViewLocalization()
                    .AddDataAnnotationsLocalization(options =>
                    {
                        options.DataAnnotationLocalizerProvider = (type, factory) =>
                        {
                            var assemblyName = new AssemblyName(typeof(ShareResource).GetTypeInfo().Assembly.FullName);
                            return factory.Create("ShareResource", assemblyName.Name);
                        };
                    });
            services.Configure<RequestLocalizationOptions>(
                option =>
                {
                    var supportedCultures = new List<CultureInfo>
                    {
                        new CultureInfo("vi"),
                        new CultureInfo("en"),
                    };
                    option.DefaultRequestCulture = new RequestCulture(culture: "en", uiCulture: "en");
                    option.SupportedCultures = supportedCultures;
                    option.SupportedUICultures = supportedCultures;
                    option.RequestCultureProviders.Insert(0 , new QueryStringRequestCultureProvider());
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

            var locOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();
            //app.MapHub<ChatHub>("/chatHub");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<ChatHub>("/signalr-hub");
                endpoints.MapHub<CommentHub>("/signalr-hubs");
                endpoints.MapHub<RatingHub>("/signalr-hubrs");
            });
        }
    }
}
