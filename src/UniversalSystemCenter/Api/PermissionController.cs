using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 权限控制器
    /// </summary>
    public class PermissionController : CrudControllerBase<PermissionDto, PermissionQuery> {
        /// <summary>
        /// 初始化权限控制器
        /// </summary>
        /// <param name="service">权限服务</param>
        public PermissionController( IPermissionService service ) : base( service ) {
            PermissionService = service;
        }

        /// <summary>
        /// 权限服务
        /// </summary>
        public IPermissionService PermissionService { get; }
    }
}