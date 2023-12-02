﻿using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FinalProject
{
    public class startup
    {
        public startup(IConfiguration configuration) {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StateContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("StateContext")));



            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;



            });
            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllersRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
            });
            */
            
        }

    }
}
