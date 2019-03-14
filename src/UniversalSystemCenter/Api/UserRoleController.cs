using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 用户角色控制器
    /// </summary>
    public class UserRoleController : CrudControllerBase<UserRoleDto, UserRoleQuery> {
        /// <summary>
        /// 初始化用户角色控制器
        /// </summary>
        /// <param name="service">用户角色服务</param>
        public UserRoleController( IUserRoleService service ) : base( service ) {
            UserRoleService = service;
        }

        /// <summary>
        /// 用户角色服务
        /// </summary>
        public IUserRoleService UserRoleService { get; }
    }
}