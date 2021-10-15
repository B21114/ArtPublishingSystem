using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationById
{
    /// <summary>
    /// Данные запроса на получения обработчиком публикации по Id.
    /// </summary>
    public class GetPublicationByIdRequestHandler: IRequestHandler<GetPublicationByIdRequest, GetPublicationByIdResponse>
    {
        public Guid Id { get; set; }

        public Task<GetPublicationByIdResponse> Handle(GetPublicationByIdRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
