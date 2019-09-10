using Klanik_Internal.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Klanik_Internal.Repository {
    public class CountryRepository : IRepository<Contry> {
        private readonly IServiceProvider _provider;
        public CountryRepository(IServiceProvider provider)
        {
            _provider = provider;
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
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                return _context.Countries;
            }
        }

        public Contry GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IRepository<Contry> Include(Expression<Func<Contry, object>> path)
        {
            throw new NotImplementedException();
        }

        public void Update(Contry toEdit)
        {
            throw new NotImplementedException();
        }
    }
}
