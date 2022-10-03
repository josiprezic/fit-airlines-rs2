using FitAirlines.WebAPI.Converters;
using FitAirlines.WebAPI.Database;
using FitAirlines.WebAPI.Filters;
using FitAirlines.WebAPI.Security;
using FitAirlines.WebAPI.Services;
using FitAirlines.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace FitAirlines.WebAPI
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
            services.AddMvc(x =>
            {
                x.Filters.Add<ErrorFilter>();
                x.EnableEndpointRouting = false;
            });

            services.AddControllers()
            .AddJsonOptions(options =>
                options.JsonSerializerOptions.Converters.Add(new TimeSpanToStringConverter()));

            services.AddAutoMapper(typeof(Startup));


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FitAirlines API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });
            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IMembershipTypesService, MembershipTypesService>();
            services.AddScoped<IOfferTypesService, OfferTypesService>();
            services.AddScoped<IUserRolesService, UserRolesService>();
            services.AddScoped<IOffersService, OffersService>();
            services.AddScoped<IFlightsService, FlightsService>();
            services.AddScoped<ICountriesService, CountriesService>();
            services.AddScoped<ICitiesService, CitiesService>();
            services.AddScoped<IAirportsService, AirportsService>();
            services.AddScoped<IPlanesService, PlanesService>();
            services.AddScoped<IReservationsService, ReservationsService>();
            services.AddScoped<IReservedSeatsService, ReservedSeatsService>();
            services.AddScoped<IRatingsService, RatingsService>();

            //SZEF
            //var connection = Configuration.GetConnectionString("docker");
            var connection = Configuration.GetConnectionString("local");

            services.AddDbContext<FitAirlinesContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.

            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "FitAirlines API v1");
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
