using AutoMapper;
using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using MediatR;

namespace CQRSales.Application.Features.Commands.CategoryCommands
{
    public class CategoryUnArchivedCommands : IRequest<bool>
    {
        public int ID { get; set; }
    }

    public class CategoryUnArchivedCommandsHandler : IRequestHandler<CategoryUnArchivedCommands, bool>
    {
        private readonly IGenericRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryUnArchivedCommandsHandler(IGenericRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CategoryUnArchivedCommands request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIDAsync(request.ID);
            if (category == null)
            {
                return false;
            }
            _repository.UnArchived(category);
            var state = await _repository.SaveChangesAsync();
            return state;
        }
    }
}
