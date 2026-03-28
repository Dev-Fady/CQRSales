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
    public class CategoryArchivedCommands : IRequest<bool>
    {
        public int ID { get; set; }
    }
    public class CategoryArchivedCommandsHandler : IRequestHandler<CategoryArchivedCommands, bool>
    {
        private readonly IGenericRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryArchivedCommandsHandler(IGenericRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CategoryArchivedCommands request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIDAsync(request.ID);
            if (category == null)
            {
                return false;
            }
            _repository.Archived(category);
            var state = await _repository.SaveChangesAsync();
            return state;
        }
    }
}
