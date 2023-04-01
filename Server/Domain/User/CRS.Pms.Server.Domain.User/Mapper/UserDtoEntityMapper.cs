using CRS.Pms.Common.Dto;
using CRS.Pms.Server.DBContext;
using CRS.Pms.Server.Mapper;

namespace CRS.Pms.Server.Domain.User.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDtoEntityMapper : IUserDtoEntityMapper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public UserDto ToDto(DBContext.User entity)
        {
            if (entity == null)
            {
                return null;
            }

            var dto = new UserDto();

            dto.Id = entity.Id;
            dto.RealName = entity.RealName;
            dto.AccoutName = entity.AccoutName;
            
            return dto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<UserDto> ToDtos(IEnumerable<DBContext.User> entities)
        {
            if (entities == null)
            {
                return null;
            }
            return entities.Select(e => this.ToDto(e));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public IEnumerable<DBContext.User> ToEntities(IEnumerable<UserDto> dtos)
        {
            if (dtos == null)
            {
                return null;
            }
            return dtos.Select(d => this.ToEntity(d));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="isUpdate"></param>
        /// <returns></returns>
        public DBContext.User ToEntity(UserDto dto, bool isUpdate = false)
        {
            if (dto == null)
            {
                return null;
            }

            var entity = new DBContext.User();
            if (isUpdate)
            {
                entity.Id = dto.Id;
            }
            entity.RealName = dto.RealName;
            entity.AccoutName = dto.AccoutName;

            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public DBContext.User ToEntityOnlyKeys(UserDto dto)
        {
            return new DBContext.User { Id = dto.Id };
        }
    }
}