using APS.DBS.Domain;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
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
    public class GetPublicationByIdRequestHandler : IRequestHandler<GetPublicationByIdRequest, GetPublicationByIdResponse>
    {
        private readonly IContentDbContext _contentDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IMapper _mapper;

        public async Task<GetPublicationByIdResponse> Handle(GetPublicationByIdRequest request, CancellationToken cancellationToken)
        {
            var contentEntity = await _contentDbContext.Contents.FindAsync(request.Id);

            return new GetPublicationByIdResponse
            {
                Result = _mapper.Map<PublicationDetailsDto>(contentEntity)
            };
        }
    }
}
