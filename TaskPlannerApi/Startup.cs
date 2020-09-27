using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using TaskPlannerApi.Repositories;

namespace TaskPlannerApi
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
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<TaskPlannerDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Default")));

            services.AddScoped<ISprocRepository, SprocRepository>();

            services.AddSwaggerGen((options) =>
            {
                options.DescribeAllEnumsAsStrings();
                options.SwaggerDoc("v1", new Info { Title = "Task Planner API", Version = "v1" });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(actions =>
            {
                actions.SwaggerEndpoint("/swagger/v1/swagger.json", "Task Planner API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
