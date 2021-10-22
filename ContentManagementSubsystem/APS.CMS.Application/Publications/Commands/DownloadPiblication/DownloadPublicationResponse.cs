using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Commands.DownloadPublication
{
    /// <summary>
    /// Ответ.
    /// </summary>
    public class DownloadPublicationResponse
    {
        /// <summary>
        /// Скачиваемый файл.
        /// </summary>
        public IFormFile DownloadFile { get; set; }
    }
}
