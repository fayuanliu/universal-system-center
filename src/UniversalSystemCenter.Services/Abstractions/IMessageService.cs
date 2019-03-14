using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 消息服务
    /// </summary>
    public interface IMessageService : ICrudService<MessageDto, MessageQuery> {
    }
}