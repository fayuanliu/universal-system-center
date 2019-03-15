using System;
using System.Collections.Generic;
using System.Text;
using UniversalSystemCenter.Domains.DominaServices.Param;

namespace UniversalSystemCenter.Domains.DominaServices.Interface
{
    /// <summary>
    /// 菜单领域服务
    /// </summary>
    public interface IMenuDomainService
    {
        /// <summary>
        /// 获取角色菜单
        /// </summary>
        /// <param name="roleIdList"></param>
        /// <returns></returns>
        List<MenuShortDto> GetRoleMenus(List<Guid> roleIdList, Guid appId);

        /// <summary>
        /// 获取所有树形菜单
        /// </summary>
        /// <returns></returns>
        List<MenuShortDto> LoadTree(Guid appId);
    }
}
