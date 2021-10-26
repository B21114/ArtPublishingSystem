﻿using APS.DBS.Domain;
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

namespace APS.CMS.Application.Publications.Commands.DownloadPublication
{
    /// <summary>
    /// Обработчик запросов.
    /// </summary>
    public class DownloadPublicationRequestHandler
: IRequestHandler<DownloadPublicationRequest, DownloadPublicationResponse>
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
        public DownloadPublicationRequestHandler(
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
        /// Поток обрабатывает запрос, отвечает значением типа DownloadPublicationResponse,
        /// запрашивает тип DownloadPublicationRequest.
        /// </summary>
        /// <param name="request">Переменная для обращения к DownloadPublicationRequest</param>
        /// <param name="cancellationToken">Объект для наблюдения за ожиданием завершения задачи.</param>
        /// <returns></returns>
        public async Task<DownloadPublicationResponse> Handle(
           DownloadPublicationRequest request,
           CancellationToken cancellationToken)
        {
            var user = await _applicationContext.Users
                .FindAsync(new Guid(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value));

            var person = new Person { Id = user.PersonId };

            // Получение файла по Id.
            var content = await _contentDbContext.Contents.FindAsync(request.IdRecord);

            // Проверка публичности файла, если файл не публичный, то проверяем, является ли пользователь владельцем файла.
            if (content.IsPublic == true)
            {
                // Возвращает экземпляр класса DownloadPublicationResponse.
                return new DownloadPublicationResponse
                {
                    FileName = content.File.FileName,

                    FileContent = content.File.FileContent,

                    FileExtension = content.File.FileExtension
                };
            }
            else
            {
                if (person == content.Author)
                {
                    return new DownloadPublicationResponse
                    {
                        FileName = content.File.FileName,

                        FileContent = content.File.FileContent,

                        FileExtension = content.File.FileExtension
                    };
                }
                else
                    return new DownloadPublicationResponse();
            }
        }
    }
}