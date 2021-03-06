﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Models.ViewModels
{
    public class KonsultantCreationModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Function { get; set; }
        public DateTime Availability { get; set; }

        public List<CompetenceViewModel> Competences { get; set; }
        public List<LanguageViewModel> Languages { get; set; }
        public List<EducationViewModel> Educations { get; set; }
        public List<CertificateViewModel> Certificates { get; set; }
        public List<ProfessionalExperienceViewModel> ProfessionalExperiences { get; set; }
        public List<ProfessionalReferenceViewModel> ProfessionalReferences { get; set; }

        public KonsultantCreationModel()
        {
            Competences = new List<CompetenceViewModel>();
            Languages = new List<LanguageViewModel>();
            Educations = new List<EducationViewModel>();
            Certificates = new List<CertificateViewModel>();
            ProfessionalExperiences = new List<ProfessionalExperienceViewModel>();
            ProfessionalReferences = new List<ProfessionalReferenceViewModel>();
        }
    }

    public class CompetenceViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public int Rating { get; set; }

        public bool IsRelevant { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class LanguageViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public int Fluency { get; set; }

        public bool IsRelevant { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class CertificateViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public DateTime Obtension { get; set; }
        public DateTime? EndOfValidity { get; set; }

        public bool IsRelevant { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class EducationViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsRelevant { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class ProfessionalExperienceViewModel
    {
        public string Id { get; set; }
        public string Position { get; set; }
        public string Summary { get; set; }
        public string Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsRelevant { get; set; }
        public bool IsDeleted { get; set; }

        public List<AccomplishmentViewModel> Accomplishments { get; set; }
        public List<TechnicalEnvironmentViewModel> TechnicalEnvironments { get; set; }

        public ProfessionalExperienceViewModel()
        {
            Accomplishments = new List<AccomplishmentViewModel>();
            TechnicalEnvironments = new List<TechnicalEnvironmentViewModel>();
        }
    }

    public class AccomplishmentViewModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public bool IsRelevant { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class TechnicalEnvironmentViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsRelevant { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class ProfessionalReferenceViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Function { get; set; }
        public string Company { get; set; }
    }

}
