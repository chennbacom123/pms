using CRS.Pms.Server.DBContext;
using CRS.Pms.Server.Repository;

namespace CRS.Pms.Server.Domain.User.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository : Repository<DBContext.User>, IUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public UserRepository(IDBContext context) : base(context)
        {
        }
    }
}
