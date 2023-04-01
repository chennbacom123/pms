using SqlSugar;

namespace CRS.Pms.Server.DBContext
{
    /// <summary>
    /// 
    /// </summary>
    public class Entity
    {
        [SugarColumn(IsPrimaryKey =true)]
        public string Id { get; set;}

        /// <summary>
        /// 
        /// </summary>
        public Entity()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}