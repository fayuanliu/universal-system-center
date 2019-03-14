using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 消息控制器
    /// </summary>
    public class MessageController : CrudControllerBase<MessageDto, MessageQuery> {
        /// <summary>
        /// 初始化消息控制器
        /// </summary>
        /// <param name="service">消息服务</param>
        public MessageController( IMessageService service ) : base( service ) {
            MessageService = service;
        }

        /// <summary>
        /// 消息服务
        /// </summary>
        public IMessageService MessageService { get; }
    }
}