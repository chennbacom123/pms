using CRS.Pms.Server.DBContext;
using System.Linq.Expressions;

namespace CRS.Pms.Server.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRepository<T> : IRepository
        where T : class , IEntity, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> Add(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> Query(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyValueFunc"></param>
        /// <returns></returns>
        Task<T> Query(Func<T> keyValueFunc);
    }
}