using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
                                                                             IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options => {
                options.UseSqlServer(config.GetConnectionString("AchieverContextConnection"));

            });

            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddScoped<ITaskTodoRepository, TaskTodoRepository>();

            return services;
        }
    }
}