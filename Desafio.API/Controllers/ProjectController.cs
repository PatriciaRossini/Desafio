using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API.Controllers
{
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        } 
    }
}
