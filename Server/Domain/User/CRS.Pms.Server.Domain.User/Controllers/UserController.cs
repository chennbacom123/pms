using CRS.Pms.Common.Dto;
using CRS.Pms.Server.Domain.User.Bussiness;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;

namespace CRS.Pms.Server.Domain.User.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IUserBussiness bussiness = null;

        /// <summary>
        /// 
        /// </summary>
        public UserController(IUserBussiness bussiness)
        {
            this.bussiness = bussiness;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("detail/{userId}")]
        public async Task<IResponseDto<UserDto>> GetUserByUserId([FromRoute]string userId)
        {
            var resulit = await this.bussiness.QueryByKey(new UserDto { Id = userId }).ConfigureAwait(false);
            this.Ok(new object());
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestArg"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("list")]
        public async Task<IResponseDto<IEnumerable<UserDto>>> GetUsers(RequestArg<UserArg> requestArg)
        {
            return await this.bussiness.GetUsers(requestArg).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("add")]
        public async Task<IResponseDto<int>> Add([FromBody]RequestArg<UserArg> userArg)
        {
            return await this.bussiness.Create(userArg).ConfigureAwait(false);
        }
    }
}