using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Commands.CreatePublication
{
    /// <summary>
    /// Класс для проверки добавляемого файла.
    /// </summary>
    public class PublicationValidator : AbstractValidator<CreatePublicationRequest>
    {
        /// <summary>
        /// Проверка что поля не пустые, если пустые выброс исключения.
        /// </summary>
        public PublicationValidator()
        {
            RuleFor(rules => rules.UploadFile)
                .NotNull();

            RuleFor(rules => rules.IsPublic)
                .NotNull();

            validator.ValidateAndThrow(rules);
        }

        CreatePublicationRequest rules = new CreatePublicationRequest();
        PublicationValidator validator = new PublicationValidator();


    }
}
