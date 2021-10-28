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
        [Route("CreatePublication")]
        public async Task<IActionResult> CreatePublication([FromForm] CreatePublicationRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Метод скачивания публикации.
        /// </summary>
        /// <param name="command">Передача комманды в сервисный слой MediatR.</param>
        /// <returns>Возвращает файл.</returns>
        [HttpGet]
        [Route("DownloadPublication")]
        public async Task<IActionResult> DownloadPublication(DownloadPublicationResponse command)
        {
            var result = _mediator.Send(command);
            return File(command.FileContent, command.FileType, $"{command.FileName}.{command.FileExtension}");
        }

        /// <summary>
        /// Метод вывода информации о файле.
        /// </summary>
        /// <param name="command">Передача комманды в сервисный слой MediatR.</param>
        /// <returns>Возвращает информацию о файле.</returns>
        [HttpGet]
        [Route("GetPublication")]
        public async Task<IActionResult> GetPublicationById(GetPublicationByIdRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Метод вывода страницы.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Upload()
        {
            return View("UploadPublication");
        }

        /// <summary>
        /// Метод вывода страницы.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Download()
        {
            return View("DownloadPublication");
        }

        /// <summary>
        /// Метод вывода страницы.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPublication()
        {
            return View("GetPublicationById");
        }

        /// <summary>
        /// Метод вывода страницы.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SavePublication()
        {
            return View();
        }
    }
}
