using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;

namespace Klanik_Internal.Services {
    public class CountryService : IService<Contry> {
        private readonly IRepository<Contry> _repo;

        public CountryService(IRepository<Contry> repo)
        {
            _repo = repo;
        }
        public void Create(Contry toCreate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contry toRemove)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contry> GetAll()
        {
            return _repo.GetAll();
        }

        public Contry GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contry toEdit)
        {
            throw new NotImplementedException();
        }
    }
}
