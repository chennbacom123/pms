using CRS.Pms.Common.Dto;
using CRS.Pms.Server.Bussiness;

namespace CRS.Pms.Server.Domain.User.Bussiness
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserBussiness : IBussiness<UserArg, UserDto, DBContext.User>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestArg"></param>
        /// <returns></returns>
        Task<IResponseDto<IEnumerable<UserDto>>> GetUsers(IRequestArg<UserArg> requestArg);
    }
}
