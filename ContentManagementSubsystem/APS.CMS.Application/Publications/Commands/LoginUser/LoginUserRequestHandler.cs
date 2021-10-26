using APS.Dbs.Domain.Entities.Identity;
using APS.DBS.Domain;
using APS.Web.MVC.DataBaseContext;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.LoginUser
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

            try
            {
                var user = await _signInManager.PasswordSignInAsync(request.Login, request.Password, request.RememberMe, false);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                string mes = "Упс! Что-то пошло не так.";
            }

            return new LoginUserResponse { };
        }
    }
}
