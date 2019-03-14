using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 用户权限控制器
    /// </summary>
    public class UserPermissionController : CrudControllerBase<UserPermissionDto, UserPermissionQuery> {
        /// <summary>
        /// 初始化用户权限控制器
        /// </summary>
        /// <param name="service">用户权限服务</param>
        public UserPermissionController( IUserPermissionService service ) : base( service ) {
            UserPermissionService = service;
        }

        /// <summary>
        /// 用户权限服务
        /// </summary>
        public IUserPermissionService UserPermissionService { get; }
    }
}