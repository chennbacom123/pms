namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPagingDto : IDto
    {
        /// <summary>
        /// 
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int PageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        int TotalRecordCount { get; set; }
    }
}