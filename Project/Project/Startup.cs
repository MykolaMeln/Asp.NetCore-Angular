using Project.DAL.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Project.DAL.EF;
using Project.DAL.Interfaces;
using Project.BLL.Interfaces;
using Project.DAL.Repositories;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
           services.AddDbContext<DBContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("myconn")));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DbContext>();
           
            services.AddControllers();

         /*   services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/Login");
                });*/

            /*services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project", Version = "v1" });
            });*/

          /*  services.AddSwaggerGen(config => config.SwaggerDoc("v1", new OpenApiInfo{ Title = "API", Description = "Description", Version = "v1" }));*/
            services.AddCors();
            services.AddRouting();
            services.AddMvc();
           // MvcOptions.EnableEndpointRouting = false;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();           
          
            app.UseCors(builder => builder.AllowAnyOrigin());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
            /*app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });*/
            /*  routes.MapRoute(
              name: "default",
              template: "{controller=Home}/{action=Index}/{id?}");*/
            /* app.UseSwagger();
         app.UseSwaggerUI(c =>
         {
            // string swaggerJsonBasePath = string.IsNullOrWhiteSpace(c.RoutePrefix) ? "." : "..";
           //  c.SwaggerEndpoint($"{swaggerJsonBasePath}/swagger/v1/swagger.json", "My API");
            c.RoutePrefix = "";
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project");
         });*/


        }
    }
    /* public class Startup
     {
         public Startup(IConfiguration configuration)
         {
             Configuration = configuration;
         }

         public IConfiguration Configuration { get; }
         public void ConfigureServices(IServiceCollection services)
         {
             services.Configure<CookiePolicyOptions>(options =>
             {
                 // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                 options.CheckConsentNeeded = context => true;
                 options.MinimumSameSitePolicy = SameSiteMode.None;
             });
             services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project", Version = "v1" });
             });
             string connection = Configuration.GetConnectionString("myconn");
             services.AddDbContext<DBContext>(options => options.UseSqlServer(connection));

             services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DBContext>();

             services.AddMvc();
         }

         // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
         {
             app.UseSwagger();
             app.UseSwaggerUI(c =>
             {
                 c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project");
                 c.RoutePrefix = string.Empty; 
             });

             if (env.IsDevelopment())
             {
                 app.UseDeveloperExceptionPage();
             }
             else
             {
                 app.UseExceptionHandler("/Home/Error");
                 app.UseHsts();
             }

             app.UseHttpsRedirection();
             app.UseStaticFiles();
             app.UseCookiePolicy();
             app.UseAuthentication();
         }*/

    // This method gets called by the runtime. Use this method to add services to the container.
    /* public void ConfigureServices(IServiceCollection services)
     {
         services.AddControllers();

         services.AddDbContext<DBContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("myconn")));

         services.AddIdentity<User, IdentityRole>()
             .AddEntityFrameworkStores<DBContext>();

         services.AddScoped<IUnitOfWork, EFUnitOfWork>();
        // services.AddTransient<IUserService, UserService>();
         // services.AddTransient<IArtistService, ArtistService>();

         services.AddSwaggerGen(c =>
         {
             c.SwaggerDoc("v1", new OpenApiInfo { Title = "Project", Version = "v1" });
         });

      //  services.AddAutoMapper(typeof(Startup));

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
             // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
             app.UseHsts();
         }

         app.UseHttpsRedirection();

         app.UseRouting();

         app.UseEndpoints(endpoints =>
         {
             endpoints.MapControllers();
         });

         app.UseSwagger();
         app.UseSwaggerUI(c =>
         {
             c.RoutePrefix = "";
             c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project");
         });
     }
     /*  public Startup(IConfiguration configuration)
       {
           Configuration = configuration;
       }

       public IConfiguration Configuration { get; }


       public void ConfigureServices(IServiceCollection services)
       {
           services.AddDbContext<DBContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("myconn")));

           services.AddIdentity<User, IdentityRole>()
               .AddEntityFrameworkStores<DBContext>();

           services.AddMvc();
       }


       public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
       {
           if (env.IsDevelopment())
           {
               app.UseDeveloperExceptionPage();
           }
           else
           {
               app.UseExceptionHandler("/Home/Error");
               app.UseHsts();
           }

           app.UseHttpsRedirection();
           app.UseStaticFiles();
           app.UseAuthentication();

       }*/
}

