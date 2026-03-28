using AutoMapper;
using CQRSales.Application.Features.Commands.CategoryCommands;
using CQRSales.Application.Features.Dtos.Responses.CategoryResponses;
using CQRSales.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category,CategoryReadReponseDto>().ReverseMap();
            CreateMap<Category, CategoryAddCommands>().ReverseMap();
        }
    }
}
