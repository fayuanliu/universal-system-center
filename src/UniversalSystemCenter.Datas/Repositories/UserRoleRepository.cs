using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 用户角色仓储
    /// </summary>
    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository {
        /// <summary>
        /// 初始化用户角色仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UserRoleRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}