using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PeopleAssignmentREST.Models.Data;
using PeopleAssignmentREST.Models.Repos;
using PeopleAssignmentREST.Models.Services;

namespace PeopleAssignmentREST
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PeopleContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("Default")
                    )
            );

            services.AddScoped<IPeopleRepo, DatabasePeopleRepo>();

            services.AddScoped<IPeopleService, PeopleService>();

            services.AddScoped<ICountryRepo, DatabaseCountryRepo>();

            services.AddScoped<ICountryService, CountryService>();

            services.AddScoped<ICityRepo, DatabaseCityRepo>();

            services.AddScoped<ICityService, CityService>();

            services.AddScoped<ILanguageRepo, DatabaseLanguageRepo>();

            services.AddScoped<ILanguageService, LanguageService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
