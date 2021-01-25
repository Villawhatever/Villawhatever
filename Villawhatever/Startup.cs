using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MudBlazor;
using MudBlazor.Services;
using Villawhatever.AWS;
using Villawhatever.Resources;
using Villawhatever.Shared;
using Villawhatever.Shared.Services.Implementations;
using Villawhatever.Shared.Services.Interfaces;

namespace Villawhatever
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddMudBlazorDialog();
            services.AddMudBlazorSnackbar();
            services.AddMudBlazorResizeListener();

            services.Configure<ColorConfig>(Configuration.GetSection("Colors"));

            
            var builder = new SqlConnectionStringBuilder(Configuration.GetConnectionString("Blogawhatever"));
// Debug grabs local credentials to save some AWS hits 
#if DEBUG
            builder.UserID = Configuration["dbUsername"];
            builder.Password = Configuration["dbPassword"];
#else
            var secret = AwsSecretManager.GetSecret().Result;
            builder.UserID = secret.Username,
            builder.Password = secret.Password
#endif
            
            services.AddDbContext<BlogDbContext>(options => options.UseSqlServer(builder.ConnectionString));

            services.AddTransient<IPostDataService, PostDataService>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
