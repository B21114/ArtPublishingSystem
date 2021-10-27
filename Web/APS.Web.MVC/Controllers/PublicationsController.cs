using APS.CMS.Application.Publications.Commands.CreatePublication;
using APS.CMS.Application.Publications.Commands.DownloadPublication;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Web.MVC.Controllers
{
    /// <summary>
    /// Контроллер создания публикации.
    /// </summary>
    public class PublicationsController : Controller
    {
        private readonly IMediator _mediator;
        public PublicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Метод создания публикации.
        /// </summary>
        /// <param name="command">Передача комманды в сервисный слой MediatR.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Publications/SavePublication")]
        public async Task<IActionResult> CreatePublications([FromForm] CreatePublicationRequest command)
        {
            var result = _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Метод скачивания файла
        /// </summary>
        /// <param name="command">Передача комманды в сервисный слой MediatR.</param>
        /// <returns>Возвращает файл</returns>
        [HttpGet]
        [Route("Publications/DownloadPublication")]
        public async Task<IActionResult> DownloadPublications(DownloadPublicationResponse command)
        {
            var result = _mediator.Send(command);
            return File(command.FileContent, command.FileExtension, command.FileName);
        }

        /// <summary>
        /// Метод вывода информации.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }
    }
}
