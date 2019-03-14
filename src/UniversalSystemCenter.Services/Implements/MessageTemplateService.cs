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
    /// 消息模板服务
    /// </summary>
    public class MessageTemplateService : CrudServiceBase<MessageTemplate, MessageTemplateDto, MessageTemplateQuery>, IMessageTemplateService {
        /// <summary>
        /// 初始化消息模板服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="messageTemplateRepository">消息模板仓储</param>
        public MessageTemplateService( IUniversalSysCenterUnitOfWork unitOfWork, IMessageTemplateRepository messageTemplateRepository )
            : base( unitOfWork, messageTemplateRepository ) {
            MessageTemplateRepository = messageTemplateRepository;
        }
        
        /// <summary>
        /// 消息模板仓储
        /// </summary>
        public IMessageTemplateRepository MessageTemplateRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<MessageTemplate> CreateQuery( MessageTemplateQuery param ) {
            return new Query<MessageTemplate>( param );
        }
    }
}