using Klanik_Internal.Models;
using Klanik_Internal.Models.ViewModels;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class KonsultantService : IService<Konsultant>
    {
        private readonly IRepository<Konsultant> _repo;

        public KonsultantService(IRepository<Konsultant> repo)
        {
            _repo = repo;
        }

        public void Create(Konsultant toCreate)
        {
            _repo.Create(toCreate);
        }

        public void Delete(Konsultant toRemove)
        {
            _repo.Delete(toRemove);
        }

        public IEnumerable<Konsultant> GetAll()
        {
            return _repo.GetAll();
        }

        public Konsultant GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public void Update(Konsultant toEdit)
        {
            _repo.Update(toEdit);
        }

        
    }
}
