using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 应用更新日志服务
    /// </summary>
    public interface IApplicationUpdaetLogService : ICrudService<ApplicationUpdaetLogDto, ApplicationUpdaetLogQuery> {
    }
}