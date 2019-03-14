using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 菜单仓储
    /// </summary>
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository {
        /// <summary>
        /// 初始化菜单仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MenuRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}