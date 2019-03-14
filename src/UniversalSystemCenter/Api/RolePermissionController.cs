using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 角色权限控制器
    /// </summary>
    public class RolePermissionController : CrudControllerBase<RolePermissionDto, RolePermissionQuery> {
        /// <summary>
        /// 初始化角色权限控制器
        /// </summary>
        /// <param name="service">角色权限服务</param>
        public RolePermissionController( IRolePermissionService service ) : base( service ) {
            RolePermissionService = service;
        }

        /// <summary>
        /// 角色权限服务
        /// </summary>
        public IRolePermissionService RolePermissionService { get; }
    }
}