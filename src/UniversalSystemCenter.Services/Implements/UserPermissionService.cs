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
    /// 用户权限服务
    /// </summary>
    public class UserPermissionService : CrudServiceBase<UserPermission, UserPermissionDto, UserPermissionQuery>, IUserPermissionService {
        /// <summary>
        /// 初始化用户权限服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="userPermissionRepository">用户权限仓储</param>
        public UserPermissionService( IUniversalSysCenterUnitOfWork unitOfWork, IUserPermissionRepository userPermissionRepository )
            : base( unitOfWork, userPermissionRepository ) {
            UserPermissionRepository = userPermissionRepository;
        }
        
        /// <summary>
        /// 用户权限仓储
        /// </summary>
        public IUserPermissionRepository UserPermissionRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<UserPermission> CreateQuery( UserPermissionQuery param ) {
            return new Query<UserPermission>( param );
        }
    }
}