using CRS.Pms.Common.Dto;
using CRS.Pms.Server.DBContext;
using CRS.Pms.Server.Mapper;
using CRS.Pms.Server.Repository;
using System.Linq.Expressions;

namespace CRS.Pms.Server.Bussiness
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Bussiness<TArg, TDto, TEntity> : IBussiness<TArg, TDto, TEntity>
        //where TArg : IArg
        where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly IRepository<TEntity> repository = null;

        /// <summary>
        /// 
        /// </summary>
        protected readonly IArgDtoMapper<TArg, TDto> argDtoMapper = null;

        /// <summary>
        /// 
        /// </summary>
        protected readonly IDtoEntityMapper<TDto, TEntity> dtoEntityMapper = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="argDtoMapper"></param>
        /// <param name="dtoEntityMapper"></param>
        public Bussiness(
            IRepository<TEntity> repository,
            IArgDtoMapper<TArg, TDto> argDtoMapper,
            IDtoEntityMapper<TDto, TEntity> dtoEntityMapper)
        {
            this.repository = repository;
            this.argDtoMapper = argDtoMapper;
            this.dtoEntityMapper = dtoEntityMapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public async Task<IResponseDto<int>> Create(IRequestArg<TArg> arg)
        {
            //var requestArg = new RequestArg<TArg> { Data=arg, };
            var dto = this.argDtoMapper.ToDto(arg);
            var entity = this.dtoEntityMapper.ToEntity(dto);
            var result = await this.repository.Add(entity).ConfigureAwait(false);
            return ResponseCreator.CreateResponse(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<IResponseDto<TDto>> QueryByKey(TDto key)
        {
            var entity = await this.repository
                .Query(() => this.dtoEntityMapper.ToEntityOnlyKeys(key))
                .ConfigureAwait(false);
            var dto = this.dtoEntityMapper.ToDto(entity);
            return ResponseCreator.CreateResponse(dto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IResponseDto<IEnumerable<TDto>>> Query(Expression<Func<TEntity, bool>> expression)
        {
            var entites = await this.repository
                .Query(expression)
                .ConfigureAwait(false);
            var dtos = this.dtoEntityMapper.ToDtos(entites);
            return ResponseCreator.CreateResponse(dtos);
        }
    }
}