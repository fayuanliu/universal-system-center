using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 用户角色数据传输对象
    /// </summary>
    
    public class UserRoleDto : DtoBase {
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [Required(ErrorMessage = "类型编号（TypeId）不能为空")]
        [Display( Name = "类型编号（TypeId）" )]
        [DataMember]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 用户编号（UserId)
        /// </summary>
        [Required(ErrorMessage = "用户编号（UserId)不能为空")]
        [Display( Name = "用户编号（UserId)" )]
        [DataMember]
        public Guid UserId { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        [Display( Name = "Version" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}