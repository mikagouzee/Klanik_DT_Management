using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Klanik_Internal.Services {
    public class CompetenceService : IService<Competence> {
        private readonly IRepository<Competence> _repo;

        public CompetenceService(IRepository<Competence> repo)
        {
            _repo = repo;
        }

        public void Delete(Competence toRemove)
        {
            _repo.Delete(toRemove);
        }

        public Competence GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        #region unnecessary
        public void Create(Competence toCreate)
        {
            _repo.Create(toCreate);
        }


        public IEnumerable<Competence> GetAll()
        {
            return _repo.GetAll();
        }
        public IEnumerable<Competence> GetQuerryable(string query)
        {
            return _repo.GetAll().Where(c => c.Name.StartsWith(query));
        }

        public void Update(Competence toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
