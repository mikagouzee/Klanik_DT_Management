using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class TechnicalEnvironmentService : IService<TechnicalEnvironment>
    {
        private readonly IRepository<TechnicalEnvironment> _repo;

        public TechnicalEnvironmentService(IRepository<TechnicalEnvironment> repo)
        {
            _repo = repo;
        }

        public void Delete(TechnicalEnvironment toRemove)
        {
            _repo.Delete(toRemove);
        }

        //public TechnicalEnvironment GetByName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        public TechnicalEnvironment GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        #region unnecessary
        public void Create(TechnicalEnvironment toCreate)
        {
            throw new NotImplementedException();
        }

       

        public IEnumerable<TechnicalEnvironment> GetAll()
        {
            throw new NotImplementedException();
        }

       

        public void Update(TechnicalEnvironment toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion

      

    }
}
