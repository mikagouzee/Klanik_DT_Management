using Klanik_Internal.Models;
using Klanik_Internal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Klanik_Internal.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase {
        private readonly IService<Contry> _service;
        private IMemoryCache _cache;
        public CountryController(IService<Contry> service, IMemoryCache memory)
        {
            _service = service;
            _cache = memory;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Contry> _countries = new List<Contry>();
            if (!_cache.TryGetValue("_countries", out _countries))
            {
                _countries = _service.GetAll().ToList();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
               // Keep in cache for this time, reset time if accessed.
               .SetSlidingExpiration(TimeSpan.FromDays(1));

                // Save data in cache.
                _cache.Set("_countries", _countries, cacheEntryOptions);
            }
            return Ok(_countries);
        }

    }
}