using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using CQRSales.Infrastructure.Database;
using CQRSales.Infrastructure.Repositories;
using CQRSales.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IAccountManager, AccountManager>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddIdentity<ApplicaitonUser, IdentityRole>()
              .AddEntityFrameworkStores<SalesContext>();

            services.AddHttpContextAccessor();
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = "mahmoud";
                option.DefaultChallengeScheme = "mahmoud";
            }).AddJwtBearer("mahmoud", builder =>
            {
                string secutirykey = "afslkfskwemwpe,cwpcpwrwepkrcwprkwpecmwesc.f,m/.zcm/f.dzcmf/";
                var securityKeyByte = Encoding.ASCII.GetBytes(secutirykey);
                SecurityKey securityKey = new SymmetricSecurityKey(securityKeyByte);

                builder.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    //ValidIssuer = "http://www.google.com",
                    //ValidAudience = "http://www.google.com",
                    IssuerSigningKey = securityKey
                };
                //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            });
            return services;
        }
    }
}
