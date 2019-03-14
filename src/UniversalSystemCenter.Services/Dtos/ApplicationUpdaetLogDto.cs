using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 应用更新日志数据传输对象
    /// </summary>
    
    public class ApplicationUpdaetLogDto : DtoBase {
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [Display( Name = "应用程序编号（AppId）" )]
        [DataMember]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Required(ErrorMessage = "更新时间不能为空")]
        [Display( Name = "更新时间" )]
        [DataMember]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [StringLength( 50, ErrorMessage = "版本号输入过长，不能超过50位" )]
        [Display( Name = "版本号" )]
        [DataMember]
        public string VersionNO { get; set; }
        /// <summary>
        /// 更新内容
        /// </summary>
        [StringLength( 16, ErrorMessage = "更新内容输入过长，不能超过16位" )]
        [Display( Name = "更新内容" )]
        [DataMember]
        public string Content { get; set; }
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
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}