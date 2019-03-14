using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 消息模板服务
    /// </summary>
    public interface IMessageTemplateService : ICrudService<MessageTemplateDto, MessageTemplateQuery> {
    }
}