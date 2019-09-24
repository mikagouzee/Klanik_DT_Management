using Klanik_Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Klanik_Internal.Repository {
    public interface IRepository<T> where T : KlanikEntity {
        void Create(T toCreate);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Update(T toEdit);

        void Delete(T toRemove);

        IRepository<T> Include(Expression<Func<T, object>> path);
    }




}
