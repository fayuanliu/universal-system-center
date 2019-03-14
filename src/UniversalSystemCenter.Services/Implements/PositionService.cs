using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Service.Implements {
    /// <summary>
    /// 岗位服务
    /// </summary>
    public class PositionService : CrudServiceBase<Position, PositionDto, PositionQuery>, IPositionService {
        /// <summary>
        /// 初始化岗位服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="positionRepository">岗位仓储</param>
        public PositionService( IUniversalSysCenterUnitOfWork unitOfWork, IPositionRepository positionRepository )
            : base( unitOfWork, positionRepository ) {
            PositionRepository = positionRepository;
        }
        
        /// <summary>
        /// 岗位仓储
        /// </summary>
        public IPositionRepository PositionRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Position> CreateQuery( PositionQuery param ) {
            return new Query<Position>( param );
        }
    }
}