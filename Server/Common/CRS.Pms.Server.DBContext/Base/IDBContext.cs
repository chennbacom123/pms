using System.Linq.Expressions;

namespace CRS.Pms.Server.DBContext
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDBContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> Insert<TEntity>(TEntity entity)
            where TEntity : class, IEntity, new();

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> Insert<TEntity>(List<TEntity> entities)
            where TEntity : class, IEntity, new();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> Query<TEntity>(Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity, new();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="keyValueFunc"></param>
        /// <returns></returns>
        Task<TEntity> Query<TEntity>(Func<TEntity> keyValueFunc)
            where TEntity : class, IEntity, new();
    }
}