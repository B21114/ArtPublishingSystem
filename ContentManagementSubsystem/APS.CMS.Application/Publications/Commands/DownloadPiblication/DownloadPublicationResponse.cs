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
        ///  Хранит идентификатор новой записи.
        /// </summary>
        public Guid IdRecord { get; set; }
    }
}
