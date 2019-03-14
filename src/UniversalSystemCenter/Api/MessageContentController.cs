using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 消息内容表控制器
    /// </summary>
    public class MessageContentController : CrudControllerBase<MessageContentDto, MessageContentQuery> {
        /// <summary>
        /// 初始化消息内容表控制器
        /// </summary>
        /// <param name="service">消息内容表服务</param>
        public MessageContentController( IMessageContentService service ) : base( service ) {
            MessageContentService = service;
        }

        /// <summary>
        /// 消息内容表服务
        /// </summary>
        public IMessageContentService MessageContentService { get; }
    }
}