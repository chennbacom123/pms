namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class PagingDto : IPagingDto
    {
        /// <summary>
        /// 
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TotalRecordCount { get; set; }
    }
}