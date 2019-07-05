using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;

namespace Klanik_Internal.Services {
    public class RecruiterService : IService<Recruiter> {
        private readonly IRepository<Recruiter> _repo;

        public RecruiterService(IRepository<Recruiter> repo)
        {
            _repo = repo;
        }

        public void Create(Recruiter toCreate)
        {
            _repo.Create(toCreate);
        }

        public void Delete(Recruiter toRemove)
        {
            _repo.Delete(toRemove);
        }

        public IEnumerable<Recruiter> GetAll()
        {
            return _repo.GetAll();
        }

        public Recruiter GetById(Guid id)
        {
            return _repo
                .Include(x => x.Portfolio)
                .GetById(id);
        }

        public void Update(Recruiter toEdit)
        {
            _repo.Update(toEdit);
        }


    }
}
