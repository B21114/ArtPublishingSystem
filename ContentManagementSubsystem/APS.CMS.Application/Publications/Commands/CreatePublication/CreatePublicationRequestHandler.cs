using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Commands.CreatePublication
{
    /// <summary>
    /// Обработчик запросов.
    /// </summary>
    public class CreatePublicationRequestHandler : IRequestHandler<CreatePublicationRequest, CreatePublicationResponse>
    {
        public Task<CreatePublicationResponse> Handle(CreatePublicationRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
}
