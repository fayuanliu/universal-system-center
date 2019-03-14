using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications.Trees;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Service.Implements {
    /// <summary>
    /// 地区服务
    /// </summary>
    public class AreaService : TreeServiceBase<Area, AreaDto, AreaQuery>, IAreaService {
        /// <summary>
        /// 初始化地区服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="areaRepository">地区仓储</param>
        public AreaService( IUniversalSysCenterUnitOfWork unitOfWork, IAreaRepository areaRepository )
            : base( unitOfWork, areaRepository ) {
            AreaRepository = areaRepository;
        }
        
        /// <summary>
        /// 地区仓储
        /// </summary>
        public IAreaRepository AreaRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Area> CreateQuery( AreaQuery param ) {
            return new Query<Area>( param );
        }
    }
}