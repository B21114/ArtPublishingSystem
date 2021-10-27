using APS.Dbs.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace APS.UIS.LoginUser
{
    public class LoginUserRequestHandler : IRequestHandler<LoginUserRequest, LoginUserResponse>
    {
        private readonly SignInManager<User> _signInManager;


        public LoginUserRequestHandler(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }


        public async Task<LoginUserResponse> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            var signInResult = await _signInManager.PasswordSignInAsync(request.Login, request.Password, request.RememberMe, false);

            if (!signInResult.Succeeded)
            {
                Console.WriteLine("Пользователь не зарегистрирован!");
            }
            return new LoginUserResponse { };
        }
    }
}
