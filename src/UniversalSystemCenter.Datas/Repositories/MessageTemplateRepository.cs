using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using Util.Datas.Ef.Core;

namespace UniversalSystemCenter.Data.Repositories {
    /// <summary>
    /// 消息模板仓储
    /// </summary>
    public class MessageTemplateRepository : RepositoryBase<MessageTemplate>, IMessageTemplateRepository {
        /// <summary>
        /// 初始化消息模板仓储
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        public MessageTemplateRepository( IUniversalSysCenterUnitOfWork unitOfWork ) : base( unitOfWork ) {
        }
    }
}