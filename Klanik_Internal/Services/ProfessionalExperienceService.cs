using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class ProfessionalExperienceService : IService<ProfessionalExperience>
    {
        private readonly IRepository<ProfessionalExperience> _repo;

        public ProfessionalExperienceService(IRepository<ProfessionalExperience> repo)
        {
            _repo = repo;
        }

        public ProfessionalExperience GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public void Delete(ProfessionalExperience toRemove)
        {
            _repo.Delete(toRemove);
        }


        #region unnecessary
        public void Create(ProfessionalExperience toCreate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessionalExperience> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProfessionalExperience toEdit)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
