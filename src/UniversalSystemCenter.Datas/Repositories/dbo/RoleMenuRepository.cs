using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 角色菜单仓储
    /// </summary>
    public class RoleMenuRepository : RepositoryBase<RoleMenu>, IRoleMenuRepository {
        /// <summary>
        /// 初始化角色菜单仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public RoleMenuRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}