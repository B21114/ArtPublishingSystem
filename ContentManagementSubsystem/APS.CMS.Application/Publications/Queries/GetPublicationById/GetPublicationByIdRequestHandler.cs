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

        /// <summary>
        /// Конструтктор обработчиков запроса публикаций
        /// </summary>
        /// <param name="contentDbContext">Контекст базы данных предоставляющий контент.</param>
        /// <param name="httpContextAccessor">Предоставляет доступ к текущему пользователю, если он доступен.</param>
        /// <param name="mapper">Маппер.</param>
        public GetPublicationByIdRequestHandler(IContentDbContext contentDbContext, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _contentDbContext = contentDbContext;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        /// <summary>
        /// Поток обрабатывает запрос, отвечает значением типа GetPublicationByIdResponse,
        /// запрашивает тип GetPublicationByIdRequest.
        /// </summary>
        /// <param name="request">Запрос, публичный ли файл.</param>
        /// <param name="cancellationToken">Объект для наблюдения за ожиданием завершения задачи.</param>
        /// <returns></returns>
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
