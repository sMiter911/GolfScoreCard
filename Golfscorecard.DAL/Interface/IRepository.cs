using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Golfscorecard.DAL.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Get all entities <see cref="TEntity"/>
        /// </summary>
        /// <returns>This returns a list of <see cref="TEntity"/></returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Find records by expression
        /// </summary>
        /// <param name="predicate">Expression to find records</param>
        /// <returns>This returns a list of <see cref="TEntity"/></returns>
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Add a new entry <see cref="TEntity"/> to DB
        /// </summary>
        /// <param name="entity">The new object of type <see cref="TEntity"/></param>
        /// <returns>This returns a list of <see cref="TEntity"/></returns>
        void Add(TEntity entity);

        /// <summary>
        /// Add a new list of entries <see cref="TEntity"/> to DB
        /// </summary>
        /// <param name="entities">The new list of objects of type <see cref="TEntity"/></param>
        void AddRange(IEnumerable<TEntity> entity);

        /// <summary>
        /// Delete an entry <see cref="TEntity"/> from DB
        /// </summary>
        /// <param name="entity">Entry to delete from db <see cref="TEntity"/></param>
        /// <returns>This returns a list of <see cref="TEntity"/></returns>
        void Remove(TEntity entity);

        /// <summary>
        /// Delete a range of entries <see cref="TEntity"/> from DB
        /// </summary>
        /// <param name="entities">Entries to delete from db <see cref="TEntity"/></param>
        void RemoveRange(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool Any(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Update an entry <see cref="TEntity"/> in DB
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);

        /// <summary>
        /// Find an entry <see cref="TEntity"/> in DB
        /// </summary>
        /// <param name="entity"></param>
        TEntity Find(int id);

        /// <summary>
        /// 
        /// </summary>
        int Save();




    }
}
