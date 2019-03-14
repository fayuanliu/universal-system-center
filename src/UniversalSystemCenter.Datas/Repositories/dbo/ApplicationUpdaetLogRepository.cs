using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 应用更新日志仓储
    /// </summary>
    public class ApplicationUpdaetLogRepository : RepositoryBase<ApplicationUpdaetLog>, IApplicationUpdaetLogRepository {
        /// <summary>
        /// 初始化应用更新日志仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public ApplicationUpdaetLogRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}