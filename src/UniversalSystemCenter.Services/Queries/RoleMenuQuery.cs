using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 角色菜单查询参数
    /// </summary>
    public class RoleMenuQuery : QueryParameter {
        /// <summary>
        /// 角色菜单编号（RoleMenuId）
        /// </summary>
        [Display(Name="角色菜单编号（RoleMenuId）")]
        public Guid? RoleMenuId { get; set; }
        /// <summary>
        /// 菜单编号（MenuId)
        /// </summary>
        [Display(Name="菜单编号（MenuId)")]
        public Guid? MenuId { get; set; }
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [Display(Name="类型编号（TypeId）")]
        public Guid? RoleId { get; set; }
        /// <summary>
        /// 是否半选（Half）
        /// </summary>
        [Display(Name="是否半选（Half）")]
        public byte? Half { get; set; }
    }
}