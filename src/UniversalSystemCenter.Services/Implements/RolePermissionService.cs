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
    /// 角色权限服务
    /// </summary>
    public class RolePermissionService : CrudServiceBase<RolePermission, RolePermissionDto, RolePermissionQuery>, IRolePermissionService {
        /// <summary>
        /// 初始化角色权限服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="rolePermissionRepository">角色权限仓储</param>
        public RolePermissionService( IUniversalSysCenterUnitOfWork unitOfWork, IRolePermissionRepository rolePermissionRepository )
            : base( unitOfWork, rolePermissionRepository ) {
            RolePermissionRepository = rolePermissionRepository;
        }
        
        /// <summary>
        /// 角色权限仓储
        /// </summary>
        public IRolePermissionRepository RolePermissionRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<RolePermission> CreateQuery( RolePermissionQuery param ) {
            return new Query<RolePermission>( param );
        }
    }
}