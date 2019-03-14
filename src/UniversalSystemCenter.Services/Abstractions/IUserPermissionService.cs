using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 用户权限服务
    /// </summary>
    public interface IUserPermissionService : ICrudService<UserPermissionDto, UserPermissionQuery> {
    }
}