using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 账户仓储
    /// </summary>
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository {
        /// <summary>
        /// 初始化账户仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AccountRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}