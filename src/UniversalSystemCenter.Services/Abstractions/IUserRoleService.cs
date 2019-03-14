using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 用户角色服务
    /// </summary>
    public interface IUserRoleService : ICrudService<UserRoleDto, UserRoleQuery> {
    }
}