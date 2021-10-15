using APS.DBS.Domain;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.GetPublicationList
{
    /// <summary>
    /// Данные запроса на получения обработчиком списка публикации.
    /// </summary>
    public class GetPublicationListRequestHandler
    {
        private readonly IContentDbContext _contentDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        /// <summary>
        /// Конструтктор обработчиков запроса публикаций.
        /// </summary>
        /// <param name="contentDbContext">Контекст базы данных предоставляющий контент.</param>
        /// <param name="httpContextAccessor">Предоставляет доступ к текущему пользователю, если он доступен.</param>
        /// <param name="mapper">Маппер.</param>
        public GetPublicationListRequestHandler(IContentDbContext contentDbContext,
        IHttpContextAccessor httpContextAccessor,
        IMapper mapper)
        {
            _contentDbContext = contentDbContext;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        /// <summary>
        /// Поток обрабатывает запрос, отвечает значением типа GetPublicationListRequest,
        /// запрашивает тип GetPublicationListRequest.
        /// </summary>
        /// <param name="request">Запрос, публичный ли файл.</param>
        /// <param name="cancellationToken">Объект для наблюдения за ожиданием завершения задачи.</param>
        /// <returns></returns>
        public async Task<GetPublicationListResponse> Handler(GetPublicationListRequest request, CancellationToken cancellationToken)
        {
            var contentList = await _contentDbContext.Contents.ToListAsync();

            return new GetPublicationListResponse
            {
                Result = _mapper.Map<IList<PublicationListItemDto>>(contentList)
            };
        }

    }
}
