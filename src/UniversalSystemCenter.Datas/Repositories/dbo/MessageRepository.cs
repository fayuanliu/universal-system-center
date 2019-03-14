using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 消息仓储
    /// </summary>
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository {
        /// <summary>
        /// 初始化消息仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MessageRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}