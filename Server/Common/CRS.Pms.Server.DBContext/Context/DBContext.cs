using SqlSugar;
using System.Linq.Expressions;

namespace CRS.Pms.Server.DBContext
{
    /// <summary>
    /// 
    /// </summary>
    public class DBContext : IDBContext
    {
        /// <summary>
        /// 
        /// </summary>
        private SqlSugarClient db = null;

        /// <summary>
        /// 
        /// </summary>
        public DBContext(IDBConfig config)
        {
            this.db = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = config.ConnectionString,
                DbType = (DbType)config.DBMSType,
                IsAutoCloseConnection = true,
            });

            this.db.DbMaintenance.CreateDatabase(config.DataBaseName, null);
            this.db.CodeFirst.InitTables(typeof(User));
        }

        /// <summary>
        /// 插入单条数据
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> Insert<TEntity>(TEntity entity)
            where TEntity : class,IEntity, new()
        {
            return await this.db.Insertable(entity).ExecuteCommandAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        /// <returns></returns>
        public async Task<int> Insert<TEntity>(List<TEntity> entities)
            where TEntity : class, IEntity, new()
        {
            return await this.db.Insertable(entities).ExecuteCommandAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> Query<TEntity>(Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IEntity, new()
        {
            return await this.db.Queryable<TEntity>().Where(expression).ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="keyValueFunc"></param>
        /// <returns></returns>
        public async Task<TEntity> Query<TEntity>(Func<TEntity> keyValueFunc)
            where TEntity : class, IEntity, new()
        {
            var result = this.db.Queryable<TEntity>().WhereClassByPrimaryKey(keyValueFunc.Invoke());
            return await result.FirstAsync().ConfigureAwait(false);
        }
    }
}