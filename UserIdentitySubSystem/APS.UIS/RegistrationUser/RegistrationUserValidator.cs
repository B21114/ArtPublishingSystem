using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.UIS.RegistrationUser
{
    /// <summary>
    /// Класс валидации при регистрации нового пользователя.
    /// </summary>
    public class RegistrationUserValidator : AbstractValidator<RegistrationUserRequest>
    {
        public RegistrationUserValidator()
        {
            RuleFor(rules => rules.Email).NotEmpty();
            RuleFor(rules => rules.Password).NotEmpty();
            RuleFor(rules => rules.ConfirmedPassword).NotEmpty();
            RuleFor(rules => rules.Firstname).NotEmpty();
            RuleFor(rules => rules.Patronymic).NotEmpty();
            RuleFor(rules => rules.Lastname).NotEmpty();
            RuleFor(rules => rules.ВirthDate).NotEmpty();
        }
    }
}
