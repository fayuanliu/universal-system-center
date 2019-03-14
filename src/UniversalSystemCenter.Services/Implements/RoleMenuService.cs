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
    /// 角色菜单服务
    /// </summary>
    public class RoleMenuService : CrudServiceBase<RoleMenu, RoleMenuDto, RoleMenuQuery>, IRoleMenuService {
        /// <summary>
        /// 初始化角色菜单服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="roleMenuRepository">角色菜单仓储</param>
        public RoleMenuService( IUniversalSysCenterUnitOfWork unitOfWork, IRoleMenuRepository roleMenuRepository )
            : base( unitOfWork, roleMenuRepository ) {
            RoleMenuRepository = roleMenuRepository;
        }
        
        /// <summary>
        /// 角色菜单仓储
        /// </summary>
        public IRoleMenuRepository RoleMenuRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<RoleMenu> CreateQuery( RoleMenuQuery param ) {
            return new Query<RoleMenu>( param );
        }
    }
}