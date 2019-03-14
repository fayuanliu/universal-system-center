using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 角色菜单控制器
    /// </summary>
    public class RoleMenuController : CrudControllerBase<RoleMenuDto, RoleMenuQuery> {
        /// <summary>
        /// 初始化角色菜单控制器
        /// </summary>
        /// <param name="service">角色菜单服务</param>
        public RoleMenuController( IRoleMenuService service ) : base( service ) {
            RoleMenuService = service;
        }

        /// <summary>
        /// 角色菜单服务
        /// </summary>
        public IRoleMenuService RoleMenuService { get; }
    }
}