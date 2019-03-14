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
    /// 消息内容表服务
    /// </summary>
    public class MessageContentService : CrudServiceBase<MessageContent, MessageContentDto, MessageContentQuery>, IMessageContentService {
        /// <summary>
        /// 初始化消息内容表服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="messageContentRepository">消息内容表仓储</param>
        public MessageContentService( IUniversalSysCenterUnitOfWork unitOfWork, IMessageContentRepository messageContentRepository )
            : base( unitOfWork, messageContentRepository ) {
            MessageContentRepository = messageContentRepository;
        }
        
        /// <summary>
        /// 消息内容表仓储
        /// </summary>
        public IMessageContentRepository MessageContentRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<MessageContent> CreateQuery( MessageContentQuery param ) {
            return new Query<MessageContent>( param );
        }
    }
}