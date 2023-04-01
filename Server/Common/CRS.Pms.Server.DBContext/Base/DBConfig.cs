namespace CRS.Pms.Server.DBContext
{
    /// <summary>
    /// 
    /// </summary>
    public class DBConfig : IDBConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public DBConfig()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DataBaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DBMSType DBMSType { get; set; }
    }
}