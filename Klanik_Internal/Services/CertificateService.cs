using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class CertificateService : IService<Certificate>
    {
        private readonly IRepository<Certificate> _repo;

        public CertificateService(IRepository<Certificate> repo)
        {
            _repo = repo;
        }

        public void Delete(Certificate toRemove)
        {
            _repo.Delete(toRemove);
        }

        //public Certificate GetByName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        public Certificate GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        #region unnecessary
        public void Create(Certificate toCreate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Certificate> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Update(Certificate toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion

       
    }
}
