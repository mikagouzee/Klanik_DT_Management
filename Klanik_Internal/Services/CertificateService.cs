using Klanik_Internal.Models;
using Klanik_Internal.Repository;

namespace Klanik_Internal.Services {
    public class CertificateService : Service<Certificate> {
        private readonly IRepository<Certificate> _repo;

        public CertificateService(IRepository<Certificate> repo) : base(repo)
        {
            _repo = repo;
        }

        //        public void Delete(Certificate toRemove)
        //        {
        //            _repo.Delete(toRemove);
        //        }

        //        public Certificate GetById(Guid id)
        //        {
        //            return _repo.GetById(id);
        //        }

        //        #region unnecessary
        //#warning SOLID Violation : Interface segragation.
        //        public void Create(Certificate toCreate)
        //        {
        //            throw new NotImplementedException();
        //        }

        //        public IEnumerable<Certificate> GetAll()
        //        {
        //            throw new NotImplementedException();
        //        }


        //        public void Update(Certificate toEdit)
        //        {
        //            throw new NotImplementedException();
        //        }
        //        #endregion


    }
}
