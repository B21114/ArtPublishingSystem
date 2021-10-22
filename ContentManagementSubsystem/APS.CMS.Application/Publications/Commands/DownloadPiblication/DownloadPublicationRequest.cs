using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace APS.CMS.Application.Publications.Commands.DownloadPublication
{
    /// <summary>
    /// Запрос загрузки файла.
    /// </summary>
    public class DownloadPublicationRequest : IRequest<DownloadPublicationResponse>
    {

        /// <summary>
        /// Загружаемый файл.
        /// </summary>
        public IFormFile UploadFile { get; set; }

        /// <summary>
        /// Имя загружаемого файла.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Признак публичной доступности файла.
        /// </summary>
        public bool IsPublic { get; set; }


    }
}
