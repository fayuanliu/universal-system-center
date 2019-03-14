using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 附件仓储
    /// </summary>
    public class AttachmentRepository : RepositoryBase<Attachment>, IAttachmentRepository {
        /// <summary>
        /// 初始化附件仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public AttachmentRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}