using CQRSales.Application.Features.Commands.CategoryCommands;
using CQRSales.Application.Features.Queries.CategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSales.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoriesController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIDAsync(int Id)
        {
            var query = new GetCategoryByIdQuery { Id = Id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll([FromQuery] GetCategoriesQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(CategoryAddCommands command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(CategoryUpdateCommands command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> ArchivedAsync(CategoryArchivedCommands command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }

        [HttpPost("{Id}")]
        public async Task<IActionResult> UnArchivedAsync(CategoryUnArchivedCommands command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }
    }
}
