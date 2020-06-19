﻿using Klanik_Internal.Models;
using Klanik_Internal.Models.ViewModels;
using Klanik_Internal.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Klanik_Internal.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RecruiterController : Controller {
        private readonly IService<Konsultant> _konsultantService;
        private readonly IService<Recruiter> _recruiterService;

        public RecruiterController(IService<Konsultant> konsultantService, IService<Recruiter> recruiterService)
        {
            _konsultantService = konsultantService;
            _recruiterService = recruiterService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetTest()
        {
            return Ok("Test");
        }
        [Authorize]
        [HttpGet("Portfolio/{id}")]
        public IActionResult GetPortfolio(Guid id)
        {
            var recruiter = _recruiterService.GetById(id);
            return Ok(recruiter);

        }
        [Authorize]
        [HttpPost("UpdatePortfolio")]
        public IActionResult UpdatePortfolio([FromBody]RecruiterUpdateModel model)
        {
            List<string> errorMessage = new List<string>();
            //Recruteurs should be chcked in the IDS4 if not fund
            var recruiter = _recruiterService.GetById(model.Id);
            if (recruiter is null)
            {

                recruiter = new Recruiter()
                {
                    Id = model.Id,
                    Name = model.recruiter.Name,
                    Surname = model.recruiter.Surname
                };
                _recruiterService.Create(recruiter);
                _recruiterService.Update(recruiter);

            }
            //Get List of konsultant from model
            HashSet<Guid> modelHset = new HashSet<Guid>();
            modelHset = (from k in model.Konsultants select Guid.Parse(k)).ToHashSet<Guid>();
            //Get database hashset
            HashSet<Guid> dbHset = new HashSet<Guid>();
            dbHset = recruiter.Portfolio.Select(c => c.Id).ToHashSet<Guid>();
            //Following this logic : if dbHset is bigger, we need to remove K, else we Add them.
            if (dbHset.Count > modelHset.Count)
            {
                dbHset.SymmetricExceptWith(modelHset);
                foreach (Guid id in dbHset)
                {
                    var kons = _konsultantService.GetById(id);
                    recruiter.Portfolio.Remove(kons);
                }
            }
            else
            {
                modelHset.SymmetricExceptWith(dbHset);
                foreach (Guid id in modelHset)
                {
                    var kons = _konsultantService.GetById(id);
                    if (IsKonsultantAlreadyUsed(kons))
                    {
                        errorMessage.Add($"The Konsultant {kons.Name} {kons.Surname} is already in an other portfolio");
                    }
                    else
                    {
                        recruiter.Portfolio.Add(kons);
                    }
                }
            }
            _recruiterService.Update(recruiter);
            return Ok(errorMessage);
        }

        private static bool IsKonsultantAlreadyUsed(Konsultant konsultant)
        {
            bool AlreadyInRecruiter = false;
            if (konsultant.Recruiter != null)
            {
                AlreadyInRecruiter = true;
            }

            return AlreadyInRecruiter;
        }
    }
}