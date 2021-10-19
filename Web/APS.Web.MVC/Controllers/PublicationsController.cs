using APS.CMS.Application.Publications.Commands.CreatePublication;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Web.MVC.Controllers
{
    public class PublicationsController : Controller
    {
        private readonly IMediator _mediator;
        public PublicationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("save-publication")]
        public async Task<IActionResult> CreatePublications([FromBody] CreatePublicationRequest command)
        {
            var result = _mediator.Send(command);
            return Ok(result);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
