using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationById
{
    /// <summary>
    /// Данные запроса на получения публикации по Id.
    /// </summary>
    public class GetPublicationByIdRequest: IRequest<GetPublicationByIdResponse>
    {
        public Guid Id { get; set; } = default;
    }
}
