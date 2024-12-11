using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Newtonsoft.Json;
using Rotativa.AspNetCore;

namespace ZCLINIC
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



            services.Configure<FormOptions>(x => x.ValueCountLimit = 10000);
            services.AddMvc();
            services.AddResponseCaching();




            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromSeconds(4000);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            services.AddMvc().AddJsonOptions(options =>
            {
                //options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
                options.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            });

            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                //ContractResolver = new CamelCasePropertyNamesContractResolver(),
                ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver()
            };

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //Added By Qasim
            // Configure Compression level
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Fastest);

            // Add Response compression services
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            Connection._config = Configuration;
            services.AddMvc().AddMvcOptions(options =>
                    options.Filters.Add(
                    new ResponseCacheAttribute
                    {
                        NoStore = true,
                        Location = ResponseCacheLocation.None
                    }));
        }


        public void HandleUnAutheticated(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                Logger_Core.Loging.DB_Log(Logger_Core.eLogType.Log_Negative, "Access Denied to Page", new { }, context.Request.Path.Value, "", Connection.GetLogConnection(), new ClientInfo.UserAgent(context.Request.Headers["User-Agent"]).BasicInfo, context.Connection.RemoteIpAddress.ToString(), Convert.ToInt32(context.Session.GetInt32("UserId")));
                await context.Response.WriteAsync("<h1>Error 404. PAGE NOT FOUND</h1>");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseResponseCaching();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseResponseCompression();


            //app.MapWhen(context => (PageAuth.URM_IsAuthenticated(context.Session.GetUserId(), context.GetPageURL(), context.GetIP(), context.GetCInfo())),
            //                        HandleUnAutheticated);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{area=URM}/{controller=Authentication}/{action=Index}/{id?}");
            });



        }




    }
}
