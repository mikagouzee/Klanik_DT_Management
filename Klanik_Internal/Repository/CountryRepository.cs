using Klanik_Internal.Models;
using System;

namespace Klanik_Internal.Repository {
    public class CountryRepository : Repository<Contry> {
        public CountryRepository(IServiceProvider provider) : base(provider)
        {
        }

    }
}
