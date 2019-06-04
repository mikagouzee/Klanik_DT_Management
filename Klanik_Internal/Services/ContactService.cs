using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class ContactService : IService<Contact>
    {
        private readonly IRepository<Contact> _repo;

        public ContactService(IRepository<Contact> repo)
        {
            _repo = repo;
        }

        public Contact GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public void Delete(Contact toRemove)
        {
            _repo.Delete(toRemove);
        }


        #region unnecessary
        public void Create(Contact toCreate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Contact toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
