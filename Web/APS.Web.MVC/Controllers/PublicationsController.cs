using APS.CMS.Application.Publications.Commands.CreatePublication;
using APS.CMS.Application.Publications.Commands.DownloadPublication;
using APS.CMS.Application.Publications.Queries.GetPublicationById;
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
        [Route("SavePublication")]
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
        [Route("DownloadPublication")]
        public async Task<IActionResult> DownloadPublications(DownloadPublicationResponse command)
        {
            var result = _mediator.Send(command);
            return File(command.FileContent, command.FileType, command.FileName + "." + command.FileExtension);
        }

        /// <summary>
        /// Метод скачивания файла
        /// </summary>
        /// <param name="command">Передача комманды в сервисный слой MediatR.</param>
        /// <returns>Возвращает файл</returns>
        [HttpGet]
        [Route("GetPublicationById")]
        public async Task<IActionResult> GetPublicationById(GetPublicationByIdRequest command)
        {
            var result = _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Метод вывода информации.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Upload()
        {
            return View("UploadPublication");
        }

        [HttpGet]
        public IActionResult Download()
        {
            return View("DownloadPublication");
        }

        [HttpGet]
        public IActionResult GetPublicationById()
        {
            return View();
        }
    }
}
