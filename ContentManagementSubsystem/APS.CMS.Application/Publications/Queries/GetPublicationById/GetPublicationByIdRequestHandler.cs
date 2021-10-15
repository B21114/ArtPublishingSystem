using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationById
{
    /// <summary>
    /// Данные запроса на получения обработчиком публикации по Id.
    /// </summary>
    public class GetPublicationByIdRequestHandler
    {
        public Guid Id { get; set; }
    }
}
