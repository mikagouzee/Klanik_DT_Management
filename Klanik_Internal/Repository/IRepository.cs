using Klanik_Internal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace Klanik_Internal.Repository
{
    public interface IRepository<T> where T: KlanikEntity
    {
        void Create(T toCreate);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Update(T toEdit);

        void Delete(T toRemove);

        IRepository<T> Include(Expression<Func<T, object>> path);
    }

    //see https://github.com/ovation22/BetterGenericRepository/blob/master/Example.Services/HorseService.cs
    //and  https://6figuredev.com/technology/generic-repository-dependency-injection-with-net-core/
    public class Repository<T> : IRepository<T> where T : KlanikEntity
    {
        protected IServiceProvider _provider;

        private readonly IList<Expression<Func<T, object>>> _modifiers;

        public Repository(IServiceProvider provider)
        {
            _provider = provider;
            _modifiers = new List<Expression<Func<T, object>>>();

        }

        public void Create(T toCreate)
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

        public void Update(T toEdit)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();
                _context.SaveChanges();
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

                return _context.Set<T>().ToList();
            }
        }

       
        public T GetById(Guid id)
        {
            using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                KlanikContext _context = _provider.GetService<KlanikContext>();

                var set = _modifiers.Aggregate( (IQueryable<T>)_context.Set<T>(),
                    (current, include) => current.Include(include));

                return set.FirstOrDefault(x => x.Id == id);
            }
        }

        /// <summary>
        /// Usage : "_repo.Include(x => x.MyRequestedProperty).GetById(id)"
        /// or "_repo.Include(x => x.myRequestedProperty).Get(x => x.Id== id)"
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IRepository<T> Include(Expression<Func<T, object>> path)
        {
            _modifiers.Add(path);

            return this;
        }

    }




}
