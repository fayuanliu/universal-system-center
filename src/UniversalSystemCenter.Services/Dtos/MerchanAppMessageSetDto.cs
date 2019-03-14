using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 商户应用消息设置数据传输对象
    /// </summary>
    [Model("model")]
    public class MerchanAppMessageSetDto : DtoBase {
        /// <summary>
        /// 消息分类编号（MessageCategoryId）
        /// </summary>
        [Display( Name = "消息分类编号（MessageCategoryId）" )]
        [DataMember]
        public Guid? CategoryId { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [Required(ErrorMessage = "消息类型不能为空")]
        [Display( Name = "消息类型" )]
        [DataMember]
        public int Type { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [Required(ErrorMessage = "状态（State）不能为空")]
        [Display( Name = "状态（State）" )]
        [DataMember]
        public int State { get; set; }
        /// <summary>
        /// 会员（MemberId）
        /// </summary>
        [Required(ErrorMessage = "会员（MemberId）不能为空")]
        [Display( Name = "会员（MemberId）" )]
        [DataMember]
        public Guid MerchanId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
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