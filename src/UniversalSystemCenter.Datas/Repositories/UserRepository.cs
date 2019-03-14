using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 用户仓储
    /// </summary>
    public class UserRepository : RepositoryBase<User>, IUserRepository {
        /// <summary>
        /// 初始化用户仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public UserRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}