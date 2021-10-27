using APS.Dbs.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APS.UIS.Application.LoginOut
{
    public class LogOutRequestHandler :IRequestHandler<LogOutRequest, LogOutResponse>
    {
        private readonly SignInManager<User> _signInManager;

        public LogOutRequestHandler(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<LogOutResponse> Handle(LogOutRequest request, CancellationToken cancellationToken)
        {
            await _signInManager.SignOutAsync();
            
            return new LogOutResponse { };
        }
    }
}
