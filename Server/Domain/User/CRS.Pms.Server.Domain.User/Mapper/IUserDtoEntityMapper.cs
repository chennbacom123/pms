using CRS.Pms.Common.Dto;
using CRS.Pms.Server.Mapper;

namespace CRS.Pms.Server.Domain.User.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserDtoEntityMapper : IDtoEntityMapper<UserDto, DBContext.User>
    {
    }
}