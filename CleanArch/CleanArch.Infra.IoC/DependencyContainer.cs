using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();
            //Infra.Data  Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            return services;
        }
    }
}
