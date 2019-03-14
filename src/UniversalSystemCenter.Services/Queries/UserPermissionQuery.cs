using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 用户权限查询参数
    /// </summary>
    public class UserPermissionQuery : QueryParameter {
        /// <summary>
        /// 用户权限编号
        /// </summary>
        [Display(Name="用户权限编号")]
        public Guid? UserPermissionId { get; set; }
        /// <summary>
        /// 权限编号（PermissionId）
        /// </summary>
        [Display(Name="权限编号（PermissionId）")]
        public Guid? PermissionId { get; set; }
        /// <summary>
        /// 用户编号（UserId)
        /// </summary>
        [Display(Name="用户编号（UserId)")]
        public Guid? UserId { get; set; }
    }
}