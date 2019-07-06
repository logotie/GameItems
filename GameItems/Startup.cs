using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameItems.Model;
using GameItems.Services.Games;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GameItems
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Register the service with the Dependency Injection Container, DbContext is a service
            services.AddDbContext<GameItemsContext>(opt => opt.UseInMemoryDatabase("GameItems"));
            //Specifies also that it will use an in memory database
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //Dependency Injection for the GameRetrieval service, also handles injection of the Db Context
            
            //Scoped means that a new service will be created on each request 
            services.AddScoped<IGameRetrieval, GameRetrieval>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
