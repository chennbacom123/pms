namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRequestArg<T> : IRequestArg
        //where T:IArg
    {
        /// <summary>
        /// 
        /// </summary>
        T Data { get; set; }
    }
}