using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 岗位仓储
    /// </summary>
    public class PositionRepository : RepositoryBase<Position>, IPositionRepository {
        /// <summary>
        /// 初始化岗位仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public PositionRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}