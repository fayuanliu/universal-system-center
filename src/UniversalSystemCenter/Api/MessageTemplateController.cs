using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 消息模板控制器
    /// </summary>
    public class MessageTemplateController : CrudControllerBase<MessageTemplateDto, MessageTemplateQuery> {
        /// <summary>
        /// 初始化消息模板控制器
        /// </summary>
        /// <param name="service">消息模板服务</param>
        public MessageTemplateController( IMessageTemplateService service ) : base( service ) {
            MessageTemplateService = service;
        }

        /// <summary>
        /// 消息模板服务
        /// </summary>
        public IMessageTemplateService MessageTemplateService { get; }
    }
}