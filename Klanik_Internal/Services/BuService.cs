using Klanik_Internal.Models;
using Klanik_Internal.Repository;

namespace Klanik_Internal.Services {
    public class BuService : Service<BusinessUnit> {
        private readonly IRepository<BusinessUnit> _repo;
        public BuService(IRepository<BusinessUnit> repo) : base(repo)
        {
            _repo = repo;
        }
        //public void Create(BusinessUnit toCreate)
        //{
        //    _repo.Create(toCreate);
        //}

        //public void Delete(BusinessUnit toRemove)
        //{

        //    _repo.Delete(toRemove);
        //}

        //public IEnumerable<BusinessUnit> GetAll()
        //{
        //    return _repo.GetAll();
        //}

        //public BusinessUnit GetById(Guid id)
        //{
        //    return _repo.GetById(id);
        //}


        //public void Update(BusinessUnit toEdit)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
