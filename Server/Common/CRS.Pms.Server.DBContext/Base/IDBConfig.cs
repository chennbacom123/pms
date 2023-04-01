using System.ComponentModel;

namespace CRS.Pms.Server.DBContext
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDBConfig
    {
        /// <summary>
        /// 
        /// </summary>
        string ConnectionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string DataBaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        DBMSType DBMSType { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum DBMSType
    {
        [Description("达梦")]
        DM = 5,
        [Description("MySql")]
        MySql = 0,

        /// <summary>
        /// 
        /// </summary>
        [Description("SqlServer")]
        SqlServer = 1,
    }
}