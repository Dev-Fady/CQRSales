using AutoMapper;
using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSales.Application.Features.Commands.CategoryCommands
{
    public class CategoryUpdateCommands : IRequest<bool>
    {
        public int ID { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
    }
    public class CategoryUpdateCommandsHandler : IRequestHandler<CategoryUpdateCommands, bool>
    {
        private readonly IGenericRepository<Category> _repository;
        private readonly IMapper _mapper;

        public CategoryUpdateCommandsHandler(IGenericRepository<Category> repository , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CategoryUpdateCommands request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIDAsync(request.ID);
            if (category == null)
            {
                return false;
            }

            var categoryEntity = _mapper.Map(request, category);
            _repository.Update(categoryEntity);
            var state = await _repository.SaveChangesAsync();
           
            return state;
        }
    }
}
