using Klanik_Internal.Models;
using Klanik_Internal.Models.ViewModels;
using Klanik_Internal.Services;
using Klanik_Internal.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Klanik_Internal.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class KonsultantController : Controller {
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
        //[Authorize]
        //[HttpGet("paginate/{paginationParams}")]
        //public IActionResult GetAllSortedPaged([FromBody]PaginationParams paginationParams)
        //{
        //    var pagedSortedKonsultant = _service.GetAll()
        //        .Skip(paginationParams.perPage * paginationParams.page)
        //        .Take(paginationParams.perPage);

        //    return Ok(pagedSortedKonsultant);

        //}
        [AllowAnonymous]
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var konsultant = _service.GetById(id);

            var result = _mapper.toViewModel(konsultant);

            return Ok(result);
        }

        [Authorize(Roles = "Basic User, Admin, SuperUser")]
        [HttpPost]
        public IActionResult Create([FromBody]KonsultantCreationModel konsultant)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var toC = _mapper.toKonsultant(konsultant);

            _service.Create(toC);

            return Ok(toC.Id);
        }

        [Authorize(Roles = "Basic User, Admin, SuperUser")]
        [HttpPut]
        public IActionResult Update([FromBody]KonsultantCreationModel konsultant)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest();

            var toC = _mapper.toKonsultant(konsultant);

            _service.Update(toC);
            //should return ToC.
            return Ok(toC.Id);
        }

        [Authorize(Roles = "Admin, SuperUser")]
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var toDelete = _service.GetById(id);
            if (toDelete is null)
                return NotFound();
            _service.Delete(toDelete);
            return Ok();
        }
        [HttpGet("Word/{id}")]
        public IActionResult GetWord(Guid id)
        {
            WordProcessor.Exposed exposed = new WordProcessor.Exposed();
            var doc = exposed.ExposeToApi(id);
            return File(doc.ToArray(), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", $"{id}DT.docx");
        }

        [HttpPost("OptOut/{id}")]
        public IActionResult OptOut(Guid id)
        {
            if (id == null)
                return BadRequest();
            Konsultant Opter = _service.GetById(id);
            if (Opter is null)
                return NotFound();
            try
            {
                _service.Delete(Opter);

                //We need to go and delete the User in IdentityServer as well.
            }
            catch (Exception)
            {

                throw;
            }

            return Ok();

        }
    }
}