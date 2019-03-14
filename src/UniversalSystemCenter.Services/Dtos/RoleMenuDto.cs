using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 角色菜单数据传输对象
    /// </summary>
    
    public class RoleMenuDto : DtoBase {
        /// <summary>
        /// 菜单编号（MenuId)
        /// </summary>
        [Required(ErrorMessage = "菜单编号（MenuId)不能为空")]
        [Display( Name = "菜单编号（MenuId)" )]
        [DataMember]
        public Guid MenuId { get; set; }
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [Required(ErrorMessage = "类型编号（TypeId）不能为空")]
        [Display( Name = "类型编号（TypeId）" )]
        [DataMember]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 是否半选（Half）
        /// </summary>
        [Required(ErrorMessage = "是否半选（Half）不能为空")]
        [Display( Name = "是否半选（Half）" )]
        [DataMember]
        public byte Half { get; set; }
        /// <summary>
        /// Version
        /// </summary>
        [Display( Name = "Version" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}