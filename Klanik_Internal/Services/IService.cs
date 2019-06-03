using Klanik_Internal.Models;
using Klanik_Internal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klanik_Internal.Services
{
    public interface IService<T> where T : KlanikEntity
    {
        void Create(T toCreate);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Update(T toEdit);

        void Delete(T toRemove);

        //T GetByName(string name);
    }

    public class Service<T> : IService<T> where T: KlanikEntity
    {
        private readonly IRepository<T> _repo;

        public Service(IRepository<T> repo)
        {
            _repo = repo;
        }

        public void Create(T toCreate)
        {
            _repo.Create(toCreate);
        }

        public void Delete(T toRemove)
        {
            _repo.Delete(toRemove);
        }

        public IEnumerable<T> GetAll()
        {
            return _repo.GetAll();
        }

        public T GetById(Guid id)
        {
            return _repo.GetById(id);
        }

        public void Update(T toEdit)
        {
            _repo.Update(toEdit);
        }

        
    }
}
