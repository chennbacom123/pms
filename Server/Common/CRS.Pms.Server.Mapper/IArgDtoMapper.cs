using CRS.Pms.Common.Dto;
using CRS.Pms.Server.DBContext;

namespace CRS.Pms.Server.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public interface IArgDtoMapper<TArg, TDto>
        //where TArg : IArg
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        TDto ToDto(IRequestArg<TArg> arg);

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="arg"></param>
        ///// <returns></returns>
        //TDto ToDto(TArg arg);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        TDto ToDto(IRequestArg<IEnumerable<TArg>> arg);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        IEnumerable<TDto> ToDtos(IRequestArg<TArg> arg);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        IEnumerable<TDto> ToDtos(IRequestArg<IEnumerable<TArg>> arg);
    }
}