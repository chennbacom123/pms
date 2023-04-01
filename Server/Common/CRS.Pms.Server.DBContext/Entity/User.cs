using SqlSugar;

namespace CRS.Pms.Server.DBContext
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("User")]
    public class User : Entity, IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar", Length = 20)]
        public string AccoutName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar", Length = 200)]
        public string RealName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string Password { get; set; }
    }
}