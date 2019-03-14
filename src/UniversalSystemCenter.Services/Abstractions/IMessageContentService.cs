using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 消息内容表服务
    /// </summary>
    public interface IMessageContentService : ICrudService<MessageContentDto, MessageContentQuery> {
    }
}