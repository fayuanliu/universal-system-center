using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Applications.Trees;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 资源数据传输对象
    /// </summary>
    
    public class ResourceDto : TreeDtoBase {
        /// <summary>
        /// 资源标识
        /// </summary>
        [StringLength( 500, ErrorMessage = "资源标识输入过长，不能超过500位" )]
        [Display( Name = "资源标识" )]
        [DataMember]
        public string Uri { get; set; }
        /// <summary>
        /// 资源名称
        /// </summary>
        [Required(ErrorMessage = "资源名称不能为空")]
        [StringLength( 50, ErrorMessage = "资源名称输入过长，不能超过50位" )]
        [Display( Name = "资源名称" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 资源类型
        /// </summary>
        [Required(ErrorMessage = "资源类型不能为空")]
        [Display( Name = "资源类型" )]
        [DataMember]
        public int Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        [Display( Name = "备注" )]
        [DataMember]
        public string Note { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        [Display( Name = "是否末级" )]
        [DataMember]
        public bool IsLeave { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        [Required(ErrorMessage = "路径不能为空")]
        [StringLength( 800, ErrorMessage = "路径输入过长，不能超过800位" )]
        [Display( Name = "路径" )]
        [DataMember]
        public string Path { get; set; }
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
        /// PinYin
        /// </summary>
        [Required(ErrorMessage = "PinYin不能为空")]
        [StringLength( 50, ErrorMessage = "PinYin输入过长，不能超过50位" )]
        [Display( Name = "PinYin" )]
        [DataMember]
        public string PinYin { get; set; }
        /// <summary>
        /// AppId
        /// </summary>
        [Display( Name = "AppId" )]
        [DataMember]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}