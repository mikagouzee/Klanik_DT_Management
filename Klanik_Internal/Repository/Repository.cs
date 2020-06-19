using Klanik_Internal.Extensions;
using Klanik_Internal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Klanik_Internal.Repository {
    //see https://github.com/ovation22/BetterGenericRepository/blob/master/Example.Services/HorseService.cs
    //and  https://6figuredev.com/technology/generic-repository-dependency-injection-with-net-core/
    public class Repository<T> : IRepository<T> where T : KlanikEntity {
        protected IServiceProvider _provider;

        private readonly IList<Expression<Func<T, object>>> _modifiers;

        public Repository(IServiceProvider provider)
        {
            _provider = provider;
            _modifiers = new List<Expression<Func<T, object>>>();

        }

        public virtual void Create(T toCreate)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                var exists = _context.Set<T>().Any(x => x.Id == toCreate.Id);

                _context.Entry(toCreate).State =
                    exists ?
                    EntityState.Modified :
                    EntityState.Added;

                _context.SaveChanges();
            }

        }

        public virtual void Update(T toEdit)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                _context.Entry(toEdit).State = EntityState.Modified;
                try
                {
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        public void Delete(T toRemove)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                var exists = _context.Set<T>().Any(x => x.Id == toRemove.Id);

                if (exists)
                    _context.Entry(toRemove).State = EntityState.Deleted;

                _context.SaveChanges();

            }
        }

        public IEnumerable<T> GetAll()
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                //Might wanna add a Eager /  Lazy bool for perfs.
                var query = _context.Set<T>().AsQueryable();
                foreach (var property in _context.Model.FindEntityType(typeof(T)).GetNavigations())
                {
                    query = query.Include(property.Name);

                }
                return query;
            }
        }

        public T GetById(Guid id)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext context = _provider.GetService<KlanikContext>();
                var query = context.Set<T>().Include(context.GetIncludePaths(typeof(T)));
                return query.FirstOrDefault(c => c.Id == id);
            }
        }

        public IRepository<T> Include(Expression<Func<T, object>> path)
        {
            _modifiers.Add(path);

            return this;
        }

    }


}
