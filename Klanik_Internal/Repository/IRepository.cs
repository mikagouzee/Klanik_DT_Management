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


        //TResult GetFirstOrDefault<TResult>(Expression<Func<T, TResult>> selector,
        //                                          Expression<Func<T, bool>> predicate = null,
        //                                          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //                                          Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        //                                          bool disableTracking = true);

    }

    //see https://github.com/ovation22/BetterGenericRepository/blob/master/Example.Services/HorseService.cs
    //and  https://6figuredev.com/technology/generic-repository-dependency-injection-with-net-core/
    public class Repository<T> : IRepository<T> where T : KlanikEntity
    {
        //private KlanikContext _context;
        protected IServiceProvider _provider;

        private readonly IList<Expression<Func<T, object>>> _modifiers;

        public Repository(IServiceProvider provider)
        {
            //_context = context;
            _provider = provider;
            _modifiers = new List<Expression<Func<T, object>>>();

            //table = _context.Set<T>();
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

                //    var exists = _context.Set<T>().Any(x => x.Id == toEdit.Id);

                //    _context.Entry(toEdit).State =
                //        exists ?
                //        EntityState.Modified :
                //        EntityState.Added;

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

        //public T Get(Func<T, bool> predicate)
        //{
        //    using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        //    {
        //        KlanikContext _context = _provider.GetService<KlanikContext>();

        //        var set = _modifiers.Aggregate((IQueryable<T>)_context.Set<T>(),
        //           (current, include) => current.Include(include));

        //        return set.SingleOrDefault(predicate);
        //    }
        //}       

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




        #region attemp to try include
        /////https://stackoverflow.com/questions/46374252/how-to-write-repository-method-for-theninclude-in-ef-core-2
        ///// <summary>
        ///// Gets the first or default entity based on a predicate, orderby delegate and include delegate. This method default no-tracking query.
        ///// </summary>
        ///// <param name="selector">The selector for projection.</param>
        ///// <param name="predicate">A function to test each element for a condition.</param>
        ///// <param name="orderBy">A function to order elements.</param>
        ///// <param name="include">A function to include navigation properties</param>
        ///// <param name="disableTracking"><c>True</c> to disable changing tracking; otherwise, <c>false</c>. Default to <c>true</c>.</param>
        ///// <returns>An <see cref="IPagedList{TEntity}"/> that contains elements that satisfy the condition specified by <paramref name="predicate"/>.</returns>
        ///// <remarks>This method default no-tracking query.</remarks>
        //public TResult GetFirstOrDefault<TResult>(Expression<Func<T, TResult>> selector,
        //                                          Expression<Func<T, bool>> predicate = null,
        //                                          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //                                          Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        //                                          bool disableTracking = true)
        //{

        //    using (IServiceScope scope = _provider.GetRequiredService<IServiceScopeFactory>().CreateScope())
        //    {
        //        KlanikContext _context = _provider.GetService<KlanikContext>();


        //        IQueryable<T> query = _context.Set<T>();
        //        if (disableTracking)
        //        {
        //            query = query.AsNoTracking();
        //        }

        //        if (include != null)
        //        {
        //            query = include(query);
        //        }

        //        if (predicate != null)
        //        {
        //            query = query.Where(predicate);
        //        }

        //        if (orderBy != null)
        //        {
        //            return orderBy(query).Select(selector).FirstOrDefault();
        //        }
        //        else
        //        {
        //            return query.Select(selector).FirstOrDefault();
        //        }
        //    }
        //}
        #endregion

    }




}
