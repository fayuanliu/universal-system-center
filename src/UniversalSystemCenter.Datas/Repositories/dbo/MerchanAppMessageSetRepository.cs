using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 商户应用消息设置仓储
    /// </summary>
    public class MerchanAppMessageSetRepository : RepositoryBase<MerchanAppMessageSet>, IMerchanAppMessageSetRepository {
        /// <summary>
        /// 初始化商户应用消息设置仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MerchanAppMessageSetRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}