using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 角色权限服务
    /// </summary>
    public interface IRolePermissionService : ICrudService<RolePermissionDto, RolePermissionQuery> {
    }
}