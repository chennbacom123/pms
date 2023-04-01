namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public interface IResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IPagingDto PageInfo { get; set; }
    }
}