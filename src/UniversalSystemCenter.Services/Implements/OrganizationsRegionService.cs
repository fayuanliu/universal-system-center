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
    /// 部门业务区域服务
    /// </summary>
    public class OrganizationsRegionService : CrudServiceBase<OrganizationsRegion, OrganizationsRegionDto, OrganizationsRegionQuery>, IOrganizationsRegionService {
        /// <summary>
        /// 初始化部门业务区域服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="organizationsRegionRepository">部门业务区域仓储</param>
        public OrganizationsRegionService( IUniversalSysCenterUnitOfWork unitOfWork, IOrganizationsRegionRepository organizationsRegionRepository )
            : base( unitOfWork, organizationsRegionRepository ) {
            OrganizationsRegionRepository = organizationsRegionRepository;
        }
        
        /// <summary>
        /// 部门业务区域仓储
        /// </summary>
        public IOrganizationsRegionRepository OrganizationsRegionRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<OrganizationsRegion> CreateQuery( OrganizationsRegionQuery param ) {
            return new Query<OrganizationsRegion>( param );
        }
    }
}