using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 消息类型控制器
    /// </summary>
    public class MessageCategoryController : CrudControllerBase<MessageCategoryDto, MessageCategoryQuery> {
        /// <summary>
        /// 初始化消息类型控制器
        /// </summary>
        /// <param name="service">消息类型服务</param>
        public MessageCategoryController( IMessageCategoryService service ) : base( service ) {
            MessageCategoryService = service;
        }

        /// <summary>
        /// 消息类型服务
        /// </summary>
        public IMessageCategoryService MessageCategoryService { get; }
    }
}