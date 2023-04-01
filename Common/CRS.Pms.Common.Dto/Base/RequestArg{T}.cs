namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestArg<T> : IRequestArg<T> 
        //where T:IArg
    {
        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? PageNumber { get; set; }
    }
}