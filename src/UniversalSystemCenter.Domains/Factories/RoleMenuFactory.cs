using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 角色菜单工厂
    /// </summary>
    public static class RoleMenuFactory {
        /// <summary>
        /// 创建角色菜单
        /// </summary>
        /// <param name="roleMenuId">角色菜单编号（RoleMenuId）</param>
        /// <param name="menuId">菜单编号（MenuId)</param>
        /// <param name="roleId">类型编号（TypeId）</param>
        /// <param name="half">是否半选（Half）</param>
        /// <param name="version">Version</param>
        public static RoleMenu Create( 
            Guid roleMenuId,
            Guid menuId,
            Guid roleId,
            byte half,
            Byte[] version
        ) {
            RoleMenu result;
            result = new RoleMenu( roleMenuId );
            result.MenuId = menuId;
            result.RoleId = roleId;
            result.Half = half;
            result.Version = version;
            return result;
        }
    }
}