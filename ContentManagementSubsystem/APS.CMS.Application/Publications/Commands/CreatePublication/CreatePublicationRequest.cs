using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace APS.CMS.Application.Publications.Commands.CreatePublication
{
    /// <summary>
    /// Запрос файла.
    /// </summary>
    public class CreatePublicationRequest : IRequest<CreatePublicationResponse>
    {

        /// <summary>
        /// Загружаемый файл.
        /// </summary>
        public IFormFile UploadFile { get; set; }

        /// <summary>
        /// Признак публичной доступности файла.
        /// </summary>
        public bool IsPublic { get; set; }


    }
}
