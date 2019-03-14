using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Service.Implements {
    /// <summary>
    /// 消息服务
    /// </summary>
    public class MessageService : CrudServiceBase<Message, MessageDto, MessageQuery>, IMessageService {
        /// <summary>
        /// 初始化消息服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="messageRepository">消息仓储</param>
        public MessageService( IUniversalSysCenterUnitOfWork unitOfWork, IMessageRepository messageRepository )
            : base( unitOfWork, messageRepository ) {
            MessageRepository = messageRepository;
        }
        
        /// <summary>
        /// 消息仓储
        /// </summary>
        public IMessageRepository MessageRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Message> CreateQuery( MessageQuery param ) {
            return new Query<Message>( param );
        }
    }
}