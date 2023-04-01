using CRS.Pms.Common.Dto;

namespace CRS.Pms.Server.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class ArgDtoMapper<TArg, TDto> : IArgDtoMapper<TArg, TDto>
        //where TArg : IArg
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public TDto ToDto(IRequestArg<TArg> arg)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public TDto ToDto(TArg arg)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public TDto ToDto(IRequestArg<IEnumerable<TArg>> arg)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public IEnumerable<TDto> ToDtos(IRequestArg<TArg> arg)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public IEnumerable<TDto> ToDtos(IRequestArg<IEnumerable<TArg>> arg)
        {
            return default;
        }
    }
}