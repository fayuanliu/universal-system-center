using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 组织机构仓储
    /// </summary>
    public class OrganizationsRepository : RepositoryBase<Organizations>, IOrganizationsRepository {
        /// <summary>
        /// 初始化组织机构仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public OrganizationsRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}