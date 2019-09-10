using Klanik_Internal.Models;
using Klanik_Internal.Services;
using Klanik_Internal.Tools;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Klanik_Internal.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class BuController : ControllerBase {
        private readonly IService<BusinessUnit> _service;
        private readonly IMapper _mapper;

        public BuController(IService<BusinessUnit> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_service.GetAll());
        }

        [HttpPost]
        public IActionResult Add([FromBody]BusinessUnit bu)
        {
            try
            {
                _service.Create(bu);
            }
            catch (System.Exception)
            {

                throw;
            }

            return Ok(bu);

        }
        [HttpDelete("{bu}")]
        public IActionResult Delete(Guid bu)
        {
            try
            {
                var toDelete = _service.GetById(bu);
                _service.Delete(toDelete);
            }
            catch (Exception)
            {

                throw;
            }
            return Ok(_service.GetAll());
        }
    }


}