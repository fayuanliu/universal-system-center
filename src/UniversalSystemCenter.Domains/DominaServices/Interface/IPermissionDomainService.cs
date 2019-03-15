using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Domains.DominaServices.Interface
{
    /// <summary>
    /// 权限领域服务
    /// </summary>
    public interface IPermissionDomainService
    {
        /// <summary>
        /// 根据角色获取权限点
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        List<string> GetAbilityByRoleIds(List<Guid> roleIds);
    }
}
