using Klanik_Internal.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfCreatorController : Controller
    {
        private IGenerator _generator;


        public PdfCreatorController(IGenerator generator)
        {
            _generator = generator;
        }

        [HttpGet("{konsultantId}")]
        public async Task<IActionResult> CreateCVasPDF([FromServices] INodeServices nodeServices, Guid konsultantId)
        {
            //region with node services
            var cvTemplate = _generator.GetCvTemplate(konsultantId);

            var result = await nodeServices.InvokeAsync<byte[]>("../pdf", cvTemplate);

            var res64 = Convert.ToBase64String(result);

            return Ok(res64);

        }
    }
}
