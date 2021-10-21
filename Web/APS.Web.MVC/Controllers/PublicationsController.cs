using APS.CMS.Application.Publications.Commands.CreatePublication;
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
        [Route("save-publication")]
        public async Task<IActionResult> CreatePublications([FromBody] CreatePublicationRequest command)
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
            return View();
        }
    }
}
