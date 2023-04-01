namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class ResponseDto<T> : IResponseDto<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IPagingDto PageInfo { get; set ; }
    }
}