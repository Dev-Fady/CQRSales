using AutoMapper;
using CQRSales.Application.Extentions.Pagination;
using CQRSales.Application.Features.Dtos.Responses.CategoryResponses;
using CQRSales.Application.Mapping;
using CQRSales.Domain.Extentions;
using CQRSales.Domain.Interfaces;
using CQRSales.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CQRSales.Application.Features.Queries.CategoryQueries
{
    public enum CategorySortBy
    {
        NameAr = 1,
        NameEn = 2,
        DescriptionAr = 3,
        DescriptionEn = 4
    }
    public class GetCategoriesQuery : PaginateBaseParamter , IRequest<Response<PaginatedList<CategoryReadReponseDto>>>
    {
        public string? TextSearch { get; set; }
        public CategorySortBy? OrderBy { get; set; }
        public bool? IsArchived { get; set; }
        public bool IsDesc { get; set; }
    }
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, Response<PaginatedList<CategoryReadReponseDto>>>
    {
        private readonly IGenericRepository<Category> _repository;
        //private readonly IMapper _mapper;

        public GetCategoriesQueryHandler(IGenericRepository<Category> repository ,IMapper mapper )
        {
            _repository = repository;
            //_mapper = mapper;
        }

        public async Task<Response<PaginatedList<CategoryReadReponseDto>>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var query = _repository.GetAll()
                .IF(request.IsArchived != null, a => a.IArchived == request.IsArchived)
                .FilterText(request?.TextSearch ?? "")
                .OrderGroupBy(new List<(bool condition, Expression<Func<Category, object>>)>
                {
                    ( CategorySortBy.NameAr == request.OrderBy ,  a => a.NameAr),
                    ( CategorySortBy.NameEn == request.OrderBy ,  a => a.NameEn),
                    ( CategorySortBy.DescriptionAr == request.OrderBy ,  a => a.DescriptionAr),
                    ( CategorySortBy.DescriptionEn == request.OrderBy ,  a => a.DescriptionEn),
                }, IsDesc: request.IsDesc)
                .Select(a => new CategoryReadReponseDto
                {
                    ID = a.ID,
                    NameAr = a.NameAr,
                    NameEn = a.NameEn,
                    DescriptionAr = a.DescriptionAr,
                    DescriptionEn = a.DescriptionEn,
                    IsArchived = a.IArchived
                });

                var result = await query.PaginateAsync(request.PageNumber, request.PageSize, cancellationToken);

                return Response<PaginatedList<CategoryReadReponseDto>>
                    .Success(result, "Categories fetched successfully");
            }
            catch (Exception ex)
            {
                return Response<PaginatedList<CategoryReadReponseDto>>.Fail($"Exception error {ex.Message}");
            }
        }
    }
}
