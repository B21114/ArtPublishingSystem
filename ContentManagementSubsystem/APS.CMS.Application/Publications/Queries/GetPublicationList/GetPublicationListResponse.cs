using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationList
{
    /// <summary>
    /// Данные запроса на получения ответа от списка публикаций.
    /// </summary>
    public class GetPublicationListResponse
    {
        public IList<PublicationListItemDto> Result {get;set;}
    }
}
