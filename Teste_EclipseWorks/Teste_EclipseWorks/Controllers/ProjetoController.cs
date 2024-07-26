using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_EclipseWorks.Controllers
{
    public class ProjetoController : Controller
    {
        [HttpGet("api/Index")]
        public IActionResult Index(int idProjeto)
        {
            return View();
        }

        [HttpGet("api/GetListaProjetos")]
        public IActionResult GetListaProjetos(int idProjeto)
        {
            return Ok(new { Id = idProjeto + 1 });
        }

    }
}