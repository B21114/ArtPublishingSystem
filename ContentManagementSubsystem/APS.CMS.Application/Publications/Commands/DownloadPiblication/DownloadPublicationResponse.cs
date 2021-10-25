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
        /// Имя скачиваемого файла файла.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Содержимое файла.
        /// </summary>
        public byte[] FileContent { get; set; }

        /// <summary>
        /// Расширение файла.
        /// </summary>
        public string FileExtension { get; set; }
    }
}
