using AutoMapper;
using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSales.Application.Features.Dtos.Responses.CategoryResponses;

namespace CQRSales.Application.Features.Commands.CategoryCommands
{
    public class CategoryAddCommands : IRequest<CategoryReadReponseDto?>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
    }
    public class CategoryAddCommandsHandler : IRequestHandler<CategoryAddCommands, CategoryReadReponseDto?>
    {
        private readonly IGenericRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryAddCommandsHandler(IGenericRepository<Category> repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryReadReponseDto?> Handle(CategoryAddCommands request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            _repository.Add(category);
            var state = await _repository.SaveChangesAsync();

            if (state)
            {
                return _mapper.Map<CategoryReadReponseDto>(category);
            }

            return null;
        }
    }
}
