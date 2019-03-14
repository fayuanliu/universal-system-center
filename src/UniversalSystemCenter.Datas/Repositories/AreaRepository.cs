using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 地区仓储
    /// </summary>
    public class AreaRepository : RepositoryBase<Area>, IAreaRepository {
        /// <summary>
        /// 初始化地区仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AreaRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}