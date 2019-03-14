using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 商户应用仓储
    /// </summary>
    public class MerchantAppRepository : RepositoryBase<MerchantApp>, IMerchantAppRepository {
        /// <summary>
        /// 初始化商户应用仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MerchantAppRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}