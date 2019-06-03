using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class EducationService : IService<Education>
    {
        private readonly IRepository<Education> _repo;

        public EducationService(IRepository<Education> repo)
        {
            _repo = repo;
        }

        //public Education GetByName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        public void Delete(Education toRemove)
        {
            _repo.Delete(toRemove);
        }


        public Education GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        #region unnecessary
        public void Create(Education toCreate)
        {
            throw new NotImplementedException();
        }

     
        public IEnumerable<Education> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Update(Education toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
