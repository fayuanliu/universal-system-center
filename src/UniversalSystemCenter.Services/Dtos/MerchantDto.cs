using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 商户数据传输对象
    /// </summary>
    
    public class MerchantDto : DtoBase {
        /// <summary>
        /// 商户名称
        /// </summary>
        [Required(ErrorMessage = "商户名称不能为空")]
        [StringLength( 200, ErrorMessage = "商户名称输入过长，不能超过200位" )]
        [Display( Name = "商户名称" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [Required(ErrorMessage = "启用不能为空")]
        [Display( Name = "启用" )]
        [DataMember]
        public byte IsEnabled { get; set; }
        /// <summary>
        /// 商户类型（个体，公司、业务单位、政府部门）
        /// </summary>
        [Required(ErrorMessage = "商户类型（个体，公司、业务单位、政府部门）不能为空")]
        [Display( Name = "商户类型（个体，公司、业务单位、政府部门）" )]
        [DataMember]
        public int Type { get; set; }
        /// <summary>
        /// 分销级别
        /// </summary>
        [Required(ErrorMessage = "分销级别不能为空")]
        [Display( Name = "分销级别" )]
        [DataMember]
        public byte IsDistribution { get; set; }
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