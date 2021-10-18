using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.RegistrationUser
{
    /// <summary>
    /// Класс валидации при регистрации нового пользователя.
    /// </summary>
    public class RegistrationUserValidator : AbstractValidator<RegistrationUserRequest>
    {
        public RegistrationUserValidator()
        {
            RuleFor(rules => rules.Email).NotEmpty();
            RuleFor(rules => rules.Email).NotEmpty();
            RuleFor(rules => rules.Password).NotEmpty();
            RuleFor(rules => rules.PasswordConfirmed).NotEmpty();
            RuleFor(rules => rules.Person).NotEmpty();
        }

        RegistrationUserRequest userRequest = new RegistrationUserRequest();

        RegistrationUserValidator validations = new RegistrationUserValidator();
    }
}
