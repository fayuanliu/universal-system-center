using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 消息类型服务
    /// </summary>
    public interface IMessageCategoryService : ICrudService<MessageCategoryDto, MessageCategoryQuery> {
    }
}