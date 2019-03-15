using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 角色菜单服务
    /// </summary>
    public interface IRoleMenuService : ICrudService<RoleMenuDto, RoleMenuQuery>
    {

    }
}