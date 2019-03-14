using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 角色权限查询参数
    /// </summary>
    public class RolePermissionQuery : QueryParameter {
        /// <summary>
        /// 角色权限编号（RolePermissionId）
        /// </summary>
        [Display(Name="角色权限编号（RolePermissionId）")]
        public Guid? RolePermissionId { get; set; }
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [Display(Name="类型编号（TypeId）")]
        public Guid? RoleId { get; set; }
        /// <summary>
        /// 权限编号（PermissionId）
        /// </summary>
        [Display(Name="权限编号（PermissionId）")]
        public Guid? PermissionId { get; set; }
    }
}