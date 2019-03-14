using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 消息内容表仓储
    /// </summary>
    public class MessageContentRepository : RepositoryBase<MessageContent>, IMessageContentRepository {
        /// <summary>
        /// 初始化消息内容表仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MessageContentRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}