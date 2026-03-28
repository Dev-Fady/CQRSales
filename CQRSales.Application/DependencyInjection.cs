using CQRSales.Application.Features.Commands.CategoryCommands;
using CQRSales.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssemblies(
                    typeof(CategoryAddCommands).Assembly,
                    Assembly.GetExecutingAssembly()
                    );
            });
            services.AddAutoMapper(options =>
            {
                options.AddProfile(new MappingProfile());
            });

            return services;
        }
    }
}
