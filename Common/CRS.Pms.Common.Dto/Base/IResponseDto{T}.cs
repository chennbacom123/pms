namespace CRS.Pms.Common.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public interface IResponseDto<T> : IResponseDto
    {
        T Data { get; set; }
    }
}