using AutoMapper;
using Hr.BL.Configuration;
using Hr.BL.Interaces;
using Hr.DB;
using Hr.DB.Implementations;
using EployeeHr.Services.AddressService;
using EployeeHr.Services.BranchService;
using EployeeHr.Services.MunicipalityServie;
using EployeeHr.Services.RegionService;
using EployeeHr.Services.SettlementService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Hr
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
            services.AddControllers();

            IConfigurationSection appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);
            AppSettings appSettings = appSettingsSection.Get<AppSettings>();
            var connection = appSettings.ConnectionString;
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Hr - WebApi",
                });
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<ISettlementService, SettlementService>();
            services.AddScoped<IRegionService,RegionService>();
            services.AddScoped<IMunicipalityService, MunicipalityService>();
            services.AddScoped<IAddressService, AddressService>();

            services.AddAutoMapper(c => c.AddMaps("EmployeeHr.BL"));

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hr.WebApi");
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
