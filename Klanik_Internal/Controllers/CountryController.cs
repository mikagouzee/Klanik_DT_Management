using Klanik_Internal.Models;
using Klanik_Internal.Services;
using Microsoft.AspNetCore.Mvc;

namespace Klanik_Internal.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase {
        private readonly IService<Contry> _service;
        public CountryController(IService<Contry> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

    }
}