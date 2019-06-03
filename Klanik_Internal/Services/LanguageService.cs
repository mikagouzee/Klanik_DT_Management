using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public class LanguageService : IService<Language>
    {
        private readonly IRepository<Language> _repo;

        public LanguageService(IRepository<Language> repo)
        {
            _repo = repo;
        }

        //public Language GetByName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        public void Delete(Language toRemove)
        {
            _repo.Delete(toRemove);
        }

        public Language GetById(Guid id)
        {
            return _repo.GetById(id);
        }



        #region unnecessary
        public void Create(Language toCreate)
        {
            throw new NotImplementedException();
        }

      

        public IEnumerable<Language> GetAll()
        {
            throw new NotImplementedException();
        }

      
        public void Update(Language toEdit)
        {
            throw new NotImplementedException();
        }
        #endregion

     
    }
}
