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
        ///  Хранит идентификатор записи.
        /// </summary>
        public Guid IdRecord { get; set; }
    }
}
