using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 消息类型仓储
    /// </summary>
    public class MessageCategoryRepository : RepositoryBase<MessageCategory>, IMessageCategoryRepository {
        /// <summary>
        /// 初始化消息类型仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MessageCategoryRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}