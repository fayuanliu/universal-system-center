using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 部门业务区域控制器
    /// </summary>
    public class OrganizationsRegionController : CrudControllerBase<OrganizationsRegionDto, OrganizationsRegionQuery> {
        /// <summary>
        /// 初始化部门业务区域控制器
        /// </summary>
        /// <param name="service">部门业务区域服务</param>
        public OrganizationsRegionController( IOrganizationsRegionService service ) : base( service ) {
            OrganizationsRegionService = service;
        }

        /// <summary>
        /// 部门业务区域服务
        /// </summary>
        public IOrganizationsRegionService OrganizationsRegionService { get; }
    }
}