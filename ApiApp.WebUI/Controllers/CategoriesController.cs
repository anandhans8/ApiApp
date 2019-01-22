using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiApp.Application.Categories.Models;
using ApiApp.Application.Categories.Queries;

namespace ApiApp.WebUI.Controllers
{
    public class CategoriesController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CategoryPreviewDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCategoryPreview([FromQuery] GetCategoryPreviewQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
