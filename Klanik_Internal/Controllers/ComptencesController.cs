using Klanik_Internal.Models;
using Klanik_Internal.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Klanik_Internal.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ComptencesController : Controller {
        private readonly IService<Competence> _service;
        public ComptencesController(IService<Competence> service)
        {
            _service = service;
        }
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet]
        [Route("{query}")]
        public IActionResult GetAllStartingBy(string query)
        {
            var results = _service.GetAll().Where(c => c.Name.StartsWith(query, StringComparison.InvariantCultureIgnoreCase)).ToList();
            return Ok(results);
        }
    }
}