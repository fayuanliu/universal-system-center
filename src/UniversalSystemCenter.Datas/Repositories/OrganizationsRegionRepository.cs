using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 部门业务区域仓储
    /// </summary>
    public class OrganizationsRegionRepository : RepositoryBase<OrganizationsRegion>, IOrganizationsRegionRepository {
        /// <summary>
        /// 初始化部门业务区域仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public OrganizationsRegionRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}