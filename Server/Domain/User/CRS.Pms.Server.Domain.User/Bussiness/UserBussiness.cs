using CRS.Pms.Common.Dto;
using CRS.Pms.Server.Bussiness;
using CRS.Pms.Server.Domain.User.Mapper;
using CRS.Pms.Server.Domain.User.Repository;
using SqlSugar;

namespace CRS.Pms.Server.Domain.User.Bussiness
{
    /// <summary>
    /// 
    /// </summary>
    public class UserBussiness : Bussiness<UserArg, UserDto, DBContext.User>, IUserBussiness
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //private readonly IUserRepository repository = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public UserBussiness(
            IUserRepository repository,
            IUserArgDtoMapper argDtoMapper,
            IUserDtoEntityMapper dtoEntityMapper) : base(repository, argDtoMapper, dtoEntityMapper)
        {
            //this.repository = repository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestArg"></param>
        /// <returns></returns>
        public async Task<IResponseDto<IEnumerable<UserDto>>> GetUsers(IRequestArg<UserArg> requestArg)
        {
            var exp = new Expressionable<DBContext.User>();
            if (requestArg != null && requestArg.Data != null)
            {
                if (!string.IsNullOrEmpty(requestArg.Data.Id))
                {
                    exp.And(x => x.Id.Equals(requestArg.Data.Id));
                }
                if (!string.IsNullOrEmpty(requestArg.Data.AccoutName))
                {
                    exp.And(x => x.AccoutName.Contains(requestArg.Data.AccoutName));
                }
                if (!string.IsNullOrEmpty(requestArg.Data.RealName))
                {
                    exp.And(x => x.RealName.Contains(requestArg.Data.RealName));
                }
            }
            return await this.Query(exp.ToExpression()).ConfigureAwait(false);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="expression"></param>
        ///// <returns></returns>
        //public override async Task<IResponseDto<IEnumerable<UserDto>>> Query(
        //    Expression<Func<DBContext.User, bool>> expression)
        //{
        //    var entites = await this.repository.Query(expression).ConfigureAwait(false);
        //    var dtos = this.dtoEntityMapper.ToDtos(entites);
        //    return ResponseCreator.CreateResponse(dtos);
        //}
    }
}
