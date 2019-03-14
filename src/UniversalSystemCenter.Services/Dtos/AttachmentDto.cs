using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 附件数据传输对象
    /// </summary>
    
    public class AttachmentDto : DtoBase {
        /// <summary>
        /// 附件名称（FileName)
        /// </summary>
        [StringLength( 256, ErrorMessage = "附件名称（FileName)输入过长，不能超过256位" )]
        [Display( Name = "附件名称（FileName)" )]
        [DataMember]
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型（FileType）
        /// </summary>
        [StringLength( 20, ErrorMessage = "文件类型（FileType）输入过长，不能超过20位" )]
        [Display( Name = "文件类型（FileType）" )]
        [DataMember]
        public string FileType { get; set; }
        /// <summary>
        /// 文件大小（Size）
        /// </summary>
        [Display( Name = "文件大小（Size）" )]
        [DataMember]
        public long? Size { get; set; }
        /// <summary>
        /// 远程路径（RemoteUrl）
        /// </summary>
        [StringLength( 500, ErrorMessage = "远程路径（RemoteUrl）输入过长，不能超过500位" )]
        [Display( Name = "远程路径（RemoteUrl）" )]
        [DataMember]
        public string RemoteUrl { get; set; }
        /// <summary>
        /// 本地路径（LocalUrl）
        /// </summary>
        [StringLength( 500, ErrorMessage = "本地路径（LocalUrl）输入过长，不能超过500位" )]
        [Display( Name = "本地路径（LocalUrl）" )]
        [DataMember]
        public string LocalUrl { get; set; }
        /// <summary>
        /// 宽（Width）
        /// </summary>
        [Required(ErrorMessage = "宽（Width）不能为空")]
        [Display( Name = "宽（Width）" )]
        [DataMember]
        public int Width { get; set; }
        /// <summary>
        /// 高（Height）
        /// </summary>
        [Required(ErrorMessage = "高（Height）不能为空")]
        [Display( Name = "高（Height）" )]
        [DataMember]
        public int Height { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display( Name = "商户编号" )]
        [DataMember]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 所属模块（Module）
        /// </summary>
        [StringLength( 200, ErrorMessage = "所属模块（Module）输入过长，不能超过200位" )]
        [Display( Name = "所属模块（Module）" )]
        [DataMember]
        public string Module { get; set; }
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