
using CQRSales.Application.Features.Commands.CategoryCommands;
using CQRSales.Application.Mapping;
using CQRSales.Domain.Interfaces;
using CQRSales.Infrastructure.Database;
using CQRSales.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CQRSales.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<SalesContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssemblies(
                    typeof(CategoryAddCommands).Assembly,
                    Assembly.GetExecutingAssembly()
                    );
            });
            builder.Services.AddAutoMapper(options =>
            {
                options.AddProfile(new MappingProfile());
            });
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
