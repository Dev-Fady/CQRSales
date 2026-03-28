using CQRSales.Application.Mapping;
using CQRSales.Domain.Interfaces;
using MediatR;
using SalesManagment.Domain;
using SalesManagment.Domain.AccountsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagment.Application.Features.Commands.AccountCommands
{
    public class LoginCommand : IRequest<Response<AuthUserResponseDto>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        //public LanguageRequest Language { get; set; }
    }
    public class LoginCommandHandler : IRequestHandler<LoginCommand, Response<AuthUserResponseDto>>
    {
        private readonly IAccountManager _accountManager;

        public LoginCommandHandler(IAccountManager accountManager )
        {
            _accountManager = accountManager;
        }
        public async Task<Response<AuthUserResponseDto>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = await _accountManager.LoginAsync(new LoginDto
            {
                UserName = request.UserName,
                Password = request.Password,
                //Language = request.Language
            });

            return Response<AuthUserResponseDto>.Success(response,"done login");
        }
    }
}
