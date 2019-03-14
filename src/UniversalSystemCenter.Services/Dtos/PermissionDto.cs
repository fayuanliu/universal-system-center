using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 权限数据传输对象
    /// </summary>
    
    public class PermissionDto : DtoBase {
        /// <summary>
        /// 权限名称（Name)
        /// </summary>
        [Required(ErrorMessage = "权限名称（Name)不能为空")]
        [StringLength( 50, ErrorMessage = "权限名称（Name)输入过长，不能超过50位" )]
        [Display( Name = "权限名称（Name)" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 权限点（Code）
        /// </summary>
        [Required(ErrorMessage = "权限点（Code）不能为空")]
        [StringLength( 16, ErrorMessage = "权限点（Code）输入过长，不能超过16位" )]
        [Display( Name = "权限点（Code）" )]
        [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 资源编号（ResourceId）
        /// </summary>
        [Display( Name = "资源编号（ResourceId）" )]
        [DataMember]
        public Guid? ResourceId { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [Required(ErrorMessage = "启用不能为空")]
        [Display( Name = "启用" )]
        [DataMember]
        public byte IsEnabled { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        [DataMember]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        [DataMember]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}