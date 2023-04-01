using CRS.Pms.Common.Dto;
using CRS.Pms.Server.DBContext;

namespace CRS.Pms.Server.Bussiness
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBussiness<TArg, TDto, TEntity> : IBussiness
        //where TArg : IArg
        where TEntity : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        Task<IResponseDto<int>> Create(IRequestArg<TArg> arg);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<IResponseDto<TDto>> QueryByKey(TDto key);
    }
}