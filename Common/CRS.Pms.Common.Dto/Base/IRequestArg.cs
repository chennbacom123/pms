namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRequestArg
    {
        /// <summary>
        /// 
        /// </summary>
        int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int? PageNumber { get; set; }
    }
}