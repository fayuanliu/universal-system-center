using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 附件服务
    /// </summary>
    public interface IAttachmentService : ICrudService<AttachmentDto, AttachmentQuery> {
    }
}