using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 商户仓储
    /// </summary>
    public class MerchantRepository : RepositoryBase<Merchant>, IMerchantRepository {
        /// <summary>
        /// 初始化商户仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MerchantRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}