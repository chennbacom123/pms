using CRS.Pms.Server.DBContext;
using System.Linq.Expressions;

namespace CRS.Pms.Server.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Repository<T> : IRepository<T>
        where T : class , IEntity, new()
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IDBContext context = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public Repository(IDBContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> Add(T entity)
        {
            return await this.context.Insert(entity).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> Query(Expression<Func<T, bool>> expression)
        {
            return await this.context.Query(expression).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyValueFunc"></param>
        /// <returns></returns>
        public async Task<T> Query(Func<T> keyValueFunc)
        {
            return await this.context.Query(keyValueFunc).ConfigureAwait(false);
        }
    }
}