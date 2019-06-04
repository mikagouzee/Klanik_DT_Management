using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class ProfessionalReferenceService : IService<ProfessionalReference>
    {
        private readonly IRepository<ProfessionalReference> _repo;

        public ProfessionalReferenceService(IRepository<ProfessionalReference> repo)
        {
            _repo = repo;
        }

        public ProfessionalReference GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public void Delete(ProfessionalReference toRemove)
        {
            _repo.Delete(toRemove);
        }

        #region unnecessary
        public void Create(ProfessionalReference toCreate)
        {
            throw new NotImplementedException();
        }

        

        public IEnumerable<ProfessionalReference> GetAll()
        {
            throw new NotImplementedException();
        }
        public void Update(ProfessionalReference toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
