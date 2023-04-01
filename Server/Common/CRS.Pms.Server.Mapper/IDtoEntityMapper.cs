using CRS.Pms.Server.DBContext;

namespace CRS.Pms.Server.Mapper
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDtoEntityMapper<TDto, TEntity>
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TDto ToDto(TEntity entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        IEnumerable<TDto> ToDtos(IEnumerable<TEntity> entities);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="isUpdate"></param>
        /// <returns></returns>
        TEntity ToEntity(TDto dto, bool isUpdate = false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        TEntity ToEntityOnlyKeys(TDto dto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        IEnumerable<TEntity> ToEntities(IEnumerable<TDto> dtos);
    }
}