using Klanik_Internal.Models;
using System;

namespace Klanik_Internal.Repository {
    public class BuRepository : Repository<BusinessUnit> {

        public BuRepository(IServiceProvider provider) : base(provider)
        {
        }


    }
}
