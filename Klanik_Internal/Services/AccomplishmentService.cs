﻿using Klanik_Internal.Models;
using Klanik_Internal.Repository;

namespace Klanik_Internal.Services {
    public class AccomplishmentService : Service<Accomplishment> {
        private readonly IRepository<Accomplishment> _repo;

        public AccomplishmentService(IRepository<Accomplishment> repo) : base(repo)
        {
            _repo = repo;
        }
        //public Accomplishment GetById(Guid id)
        //{
        //    return _repo.GetById(id);
        //}

        //public void Delete(Accomplishment toRemove)
        //{
        //    _repo.Delete(toRemove);
        //}

        //#region unnecessary
        //public void Create(Accomplishment toCreate)
        //{
        //    throw new NotImplementedException();
        //}



        //public IEnumerable<Accomplishment> GetAll()
        //{
        //    throw new NotImplementedException();
        //}
        //public void Update(Accomplishment toEdit)
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion
    }
}
