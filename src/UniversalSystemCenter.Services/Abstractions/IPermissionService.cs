using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 权限服务
    /// </summary>
    public interface IPermissionService : ICrudService<PermissionDto, PermissionQuery> {
    }
}