using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 资源仓储
    /// </summary>
    public class ResourceRepository : RepositoryBase<Resource>, IResourceRepository {
        /// <summary>
        /// 初始化资源仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public ResourceRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}