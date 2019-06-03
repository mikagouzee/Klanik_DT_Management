using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class CompetenceService : IService<Competence>
    {
        private readonly IRepository<Competence> _repo;

        public CompetenceService(IRepository<Competence> repo)
        {
            _repo = repo;
        }

        //public Competence GetByName(string name)
        //{
        //    throw new NotImplementedException();
        //}


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
            throw new NotImplementedException();
        }


        public IEnumerable<Competence> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Update(Competence toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
