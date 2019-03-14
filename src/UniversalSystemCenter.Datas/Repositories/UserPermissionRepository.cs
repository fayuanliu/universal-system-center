using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 用户权限仓储
    /// </summary>
    public class UserPermissionRepository : RepositoryBase<UserPermission>, IUserPermissionRepository {
        /// <summary>
        /// 初始化用户权限仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UserPermissionRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}