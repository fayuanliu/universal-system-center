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
    /// 权限服务
    /// </summary>
    public class PermissionService : CrudServiceBase<Permission, PermissionDto, PermissionQuery>, IPermissionService {
        /// <summary>
        /// 初始化权限服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="permissionRepository">权限仓储</param>
        public PermissionService( IUniversalSysCenterUnitOfWork unitOfWork, IPermissionRepository permissionRepository )
            : base( unitOfWork, permissionRepository ) {
            PermissionRepository = permissionRepository;
        }
        
        /// <summary>
        /// 权限仓储
        /// </summary>
        public IPermissionRepository PermissionRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Permission> CreateQuery( PermissionQuery param ) {
            return new Query<Permission>( param );
        }
    }
}