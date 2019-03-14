using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 用户权限数据传输对象
    /// </summary>
    
    public class UserPermissionDto : DtoBase {
        /// <summary>
        /// 权限编号（PermissionId）
        /// </summary>
        [Required(ErrorMessage = "权限编号（PermissionId）不能为空")]
        [Display( Name = "权限编号（PermissionId）" )]
        [DataMember]
        public Guid PermissionId { get; set; }
        /// <summary>
        /// 用户编号（UserId)
        /// </summary>
        [Required(ErrorMessage = "用户编号（UserId)不能为空")]
        [Display( Name = "用户编号（UserId)" )]
        [DataMember]
        public Guid UserId { get; set; }
    }
}