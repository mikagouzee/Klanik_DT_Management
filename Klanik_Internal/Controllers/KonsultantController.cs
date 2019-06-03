using Klanik_Internal.Models;
using Klanik_Internal.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;
using System;
using Klanik_Internal.Tools;
using Klanik_Internal.Models.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Klanik_Internal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KonsultantController : Controller
    {
        private readonly IService<Konsultant> _service;
        private readonly IMapper _mapper;

        public KonsultantController(IService<Konsultant> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var allConsultant = _service.GetAll();

            return Ok(allConsultant);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var konsultant = _service.GetById(id);

            var result = _mapper.toViewModel(konsultant);

            return Ok(result);
        }

        [Authorize(Roles ="Basic User, Admin, SuperUser")]
        [HttpPost]
        public IActionResult Create([FromBody]KonsultantCreationModel konsultant)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var toC = _mapper.toKonsultant(konsultant);

            _service.Create(toC);

            return Ok(toC.Id);
        }

        [Authorize(Roles ="Basic User, Admin, SuperUser")]
        [HttpPut]
        public IActionResult Update([FromBody]KonsultantCreationModel konsultant)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var toC = _mapper.toKonsultant(konsultant);

            _service.Update(toC);

            return Ok(toC.Id);
        }

    }
}