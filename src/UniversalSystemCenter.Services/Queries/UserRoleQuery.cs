using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 用户角色查询参数
    /// </summary>
    public class UserRoleQuery : QueryParameter {
        /// <summary>
        /// 用户角色编号（UserRoleId）
        /// </summary>
        [Display(Name="用户角色编号（UserRoleId）")]
        public Guid? UserRoleId { get; set; }
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [Display(Name="类型编号（TypeId）")]
        public Guid? RoleId { get; set; }
        /// <summary>
        /// 用户编号（UserId)
        /// </summary>
        [Display(Name="用户编号（UserId)")]
        public Guid? UserId { get; set; }
    }
}