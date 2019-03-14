using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 角色服务
    /// </summary>
    public interface IRoleService : ICrudService<RoleDto, RoleQuery> {
    }
}