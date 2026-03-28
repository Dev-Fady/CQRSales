using AutoMapper;
using CQRSales.Application.Exceptions;
using CQRSales.Application.Features.Dtos.Responses.CategoryResponses;
using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Application.Features.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery : IRequest<CategoryReadReponseDto>
    {
        public int Id { get; set; }
    }
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, CategoryReadReponseDto>
    {
        private readonly IGenericRepository<Category> _repository;
        private readonly IMapper _mapper;


        public GetCategoryByIdQueryHandler(IGenericRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryReadReponseDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIDAsync(request.Id);
            if (category == null)
            {
                 throw new NotFoundException();
            }
            return _mapper.Map<CategoryReadReponseDto>(category);
        }
    }
}
