using Klanik_Internal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Klanik_Internal.Repository {
    public class BuRepository : IRepository<BusinessUnit> {
        private readonly IServiceProvider _provider;
        public BuRepository(IServiceProvider provider)
        {
            _provider = provider;
        }
        public void Create(BusinessUnit toCreate)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {

                KlanikContext _context = _provider.GetService<KlanikContext>();
                var mapped = new BusinessUnit
                {
                    Contry = _context.Countries.FirstOrDefault(c => c.Id == toCreate.Contry.Id),
                    Id = toCreate.Id,
                    Name = toCreate.Name
                };
                _context.Add(mapped);
                _context.SaveChanges();

            }
        }

        public void Delete(BusinessUnit toRemove)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                _context.Remove<BusinessUnit>(toRemove);
                _context.SaveChanges();

            }
        }



        public IEnumerable<BusinessUnit> GetAll()
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                return _context.businessUnits.Include(c => c.Contry).OrderBy(c => c.Contry.Name);

            }
        }
        public BusinessUnit GetById(Guid id)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                return _context.businessUnits.Include(c => c.Contry).OrderBy(c => c.Contry.Name).FirstOrDefault(c => c.Id == id);

            }
        }

        public IRepository<BusinessUnit> Include(Expression<Func<BusinessUnit, object>> path)
        {
            throw new NotImplementedException();
        }

        public void Update(BusinessUnit toEdit)
        {
            throw new NotImplementedException();
        }

    }
}
