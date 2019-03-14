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
    /// 用户岗位服务
    /// </summary>
    public class UserPositionService : CrudServiceBase<UserPosition, UserPositionDto, UserPositionQuery>, IUserPositionService {
        /// <summary>
        /// 初始化用户岗位服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="userPositionRepository">用户岗位仓储</param>
        public UserPositionService( IUniversalSysCenterUnitOfWork unitOfWork, IUserPositionRepository userPositionRepository )
            : base( unitOfWork, userPositionRepository ) {
            UserPositionRepository = userPositionRepository;
        }
        
        /// <summary>
        /// 用户岗位仓储
        /// </summary>
        public IUserPositionRepository UserPositionRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<UserPosition> CreateQuery( UserPositionQuery param ) {
            return new Query<UserPosition>( param );
        }
    }
}