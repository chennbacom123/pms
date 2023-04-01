using CRS.Pms.Common.Dto;
using CRS.Pms.Server.Mapper;

namespace CRS.Pms.Server.Domain.User.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class UserArgDtoMapper : IUserArgDtoMapper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public UserDto ToDto(IRequestArg<UserArg> arg)
        {
            var dto = new UserDto();
            dto.Id = arg.Data.Id;
            dto.RealName = arg.Data.RealName;
            dto.AccoutName = arg.Data.AccoutName;
            return dto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public UserDto ToDto(IRequestArg<IEnumerable<UserArg>> arg)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<UserDto> ToDtos(IRequestArg<UserArg> arg)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public IEnumerable<UserDto> ToDtos(IRequestArg<IEnumerable<UserArg>> arg)
        {
            return default;
        }
    }
}