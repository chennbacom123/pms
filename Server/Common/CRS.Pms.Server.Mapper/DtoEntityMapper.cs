using CRS.Pms.Server.DBContext;

namespace CRS.Pms.Server.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public class DtoEntityMapper<TDto, TEntity> : IDtoEntityMapper<TDto, TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TDto ToDto(TEntity entity)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<TDto> ToDtos(IEnumerable<TEntity> entities)
        {
            return entities.Select(e => this.ToDto(e)) ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="isUpdate"></param>
        /// <returns></returns>
        public TEntity ToEntity(TDto dto, bool isUpdate = false)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public TEntity ToEntityOnlyKeys(TDto dto)
        {
            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> ToEntities(IEnumerable<TDto> dtos)
        {
            return dtos.Select(d => this.ToEntity(d));
        }
    }
}