using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 角色权限数据传输对象
    /// </summary>
    
    public class RolePermissionDto : DtoBase {
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [Required(ErrorMessage = "类型编号（TypeId）不能为空")]
        [Display( Name = "类型编号（TypeId）" )]
        [DataMember]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 权限编号（PermissionId）
        /// </summary>
        [Required(ErrorMessage = "权限编号（PermissionId）不能为空")]
        [Display( Name = "权限编号（PermissionId）" )]
        [DataMember]
        public Guid PermissionId { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        [Display( Name = "Version" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}