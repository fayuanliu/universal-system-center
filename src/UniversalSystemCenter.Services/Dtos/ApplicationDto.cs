using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 应用程序数据传输对象
    /// </summary>
    
    public class ApplicationDto : DtoBase {
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Required(ErrorMessage = "名称（Name）不能为空")]
        [StringLength( 100, ErrorMessage = "名称（Name）输入过长，不能超过100位" )]
        [Display( Name = "名称（Name）" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 客户端编号
        /// </summary>
        [Required(ErrorMessage = "客户端编号不能为空")]
        [StringLength( 50, ErrorMessage = "客户端编号输入过长，不能超过50位" )]
        [Display( Name = "客户端编号" )]
        [DataMember]
        public string ClientId { get; set; }
        /// <summary>
        /// 描述（Note）
        /// </summary>
        [StringLength( 500, ErrorMessage = "描述（Note）输入过长，不能超过500位" )]
        [Display( Name = "描述（Note）" )]
        [DataMember]
        public string Note { get; set; }
        /// <summary>
        /// 启用（Enabled）
        /// </summary>
        [Required(ErrorMessage = "启用（Enabled）不能为空")]
        [Display( Name = "启用（Enabled）" )]
        [DataMember]
        public bool IsEnabled { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        [StringLength( 50, ErrorMessage = "版本输入过长，不能超过50位" )]
        [Display( Name = "版本" )]
        [DataMember]
        public string VersionNo { get; set; }
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