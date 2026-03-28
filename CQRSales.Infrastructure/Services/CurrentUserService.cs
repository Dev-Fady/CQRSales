using CQRSales.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Infrastructure.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public CurrentUserService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public string UserId => _contextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        public string UserName => _contextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Name)?.Value ?? string.Empty;
        public int? StockId => _contextAccessor.HttpContext?.User?.FindFirst("StocKId") != null
                               ? Convert.ToInt32(_contextAccessor.HttpContext.User.FindFirst("StocKId").Value)
                               : (int?)null;
        //public LanguageRequest Language
        //{
        //    get
        //    {
        //        var data = _contextAccessor.HttpContext.User.Claims.FirstOrDefault(a => a.Type == "Language").Value;

        //        if (data == "Arabic")
        //            return LanguageRequest.Arabic;
        //        else
        //            return LanguageRequest.English;
        //    }
        //}
    }
}
