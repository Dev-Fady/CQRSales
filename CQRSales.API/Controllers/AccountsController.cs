using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesManagment.Application.Features.Commands.AccountCommands;
using System.Threading.Tasks;

namespace SalesManagment.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
