using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Commands.CreatePublication
{
    /// <summary>
    /// Ответ.
    /// </summary>
    public class CreatePublicationResponse
    {
        /// <summary>
        ///  Хранит идентификатор новой записи.
        /// </summary>
        public Guid IdRecord { get; set; }
    }
}
