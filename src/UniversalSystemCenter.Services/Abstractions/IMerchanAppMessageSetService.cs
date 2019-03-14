using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 商户应用消息设置服务
    /// </summary>
    public interface IMerchanAppMessageSetService : ICrudService<MerchanAppMessageSetDto, MerchanAppMessageSetQuery> {
    }
}