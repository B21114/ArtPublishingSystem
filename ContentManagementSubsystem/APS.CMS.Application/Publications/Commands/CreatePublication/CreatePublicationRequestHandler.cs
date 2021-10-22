using APS.DBS.Domain;
using APS.DBS.Domain.Entities;
using APS.Web.MVC.DataBaseContext;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Commands.CreatePublication
{
    /// <summary>
    /// Обработчик запросов.
    /// </summary>
    public class CreatePublicationRequestHandler
: IRequestHandler<CreatePublicationRequest, CreatePublicationResponse>
    {
        private readonly ApplicationContext _applicationContext;
        private readonly IContentDbContext _contentDbContext;
        private readonly IPersonDbContext _personDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// Конструктор обработчика запросов.
        /// </summary>
        /// <param name="contentDbContext">Контекст базы данных контента.</param>
        /// <param name="personDbContext">Контекст базы данных личности.</param>
        /// <param name="httpContextAccessor">Предоставляет доступ к текущему пользователю, если он доступен..</param>
        public CreatePublicationRequestHandler(
            ApplicationContext applicationContext,
            IContentDbContext contentDbContext,
            IPersonDbContext personDbContext,
            IHttpContextAccessor httpContextAccessor)
        {
            _applicationContext = applicationContext;
            _personDbContext = personDbContext;
            _contentDbContext = contentDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Поток обрабатывает запрос, отвечает значением типа CreatePublicationResponse,
        /// запрашивает тип CreatePublicationRequest.
        /// </summary>
        /// <param name="request">Переменная для обращения к CreatePublicationRequest</param>
        /// <param name="cancellationToken">Объект для наблюдения за ожиданием завершения задачи.</param>
        /// <returns></returns>
        public async Task<CreatePublicationResponse> Handle(
           CreatePublicationRequest request,
           CancellationToken cancellationToken)
        {
            var user = await _applicationContext.Users
                .FindAsync(new Guid(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value));

            var person = new Person { Id = user.PersonId };

            var file = new File();

            var content = new Content
            {
                Id = Guid.NewGuid(),
                Name = request.FileName,
                Author = person,
                IsPublic = request.IsPublic,
                UploadDateTime = DateTime.Now,
                File = file
            };

            // Начинает отслеживание сущности контент.
            await _contentDbContext.Contents.AddAsync(content);

            // Асинхронно сохраняет все изменения, внесенные в этом контексте, в основную базу данных.
            await _contentDbContext.SaveChangesAsync();

            // Возвращает экземпляр класса CreatePublicationResponse с Id новой записи.
            return new CreatePublicationResponse
            {
                IdRecord = content.Id
            };
        }
    }
}