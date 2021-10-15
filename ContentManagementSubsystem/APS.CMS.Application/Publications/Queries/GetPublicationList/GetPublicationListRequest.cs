using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationList
{
    /// <summary>
    /// Данные запроса на получение списка с контентом.
    /// </summary>
    public class GetPublicationListRequest : IRequest<GetPublicationListResponse>
    {
        public Guid Id { get; set; } = default;
    }
}
