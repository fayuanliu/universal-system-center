using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 消息内容表数据传输对象
    /// </summary>
    
    public class MessageContentDto : DtoBase {
        /// <summary>
        /// 消息分类编号（MessageCategoryId）
        /// </summary>
        [Required(ErrorMessage = "消息分类编号（MessageCategoryId）不能为空")]
        [Display( Name = "消息分类编号（MessageCategoryId）" )]
        [DataMember]
        public Guid TemplateId { get; set; }
        /// <summary>
        /// 消息标题（Title）
        /// </summary>
        [Required(ErrorMessage = "消息标题（Title）不能为空")]
        [StringLength( 100, ErrorMessage = "消息标题（Title）输入过长，不能超过100位" )]
        [Display( Name = "消息标题（Title）" )]
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        /// 发送人编号（SenderId）
        /// </summary>
        [Display( Name = "发送人编号（SenderId）" )]
        [DataMember]
        public Guid? SenderId { get; set; }
        /// <summary>
        /// 发送人（Sender)
        /// </summary>
        [StringLength( 50, ErrorMessage = "发送人（Sender)输入过长，不能超过50位" )]
        [Display( Name = "发送人（Sender)" )]
        [DataMember]
        public string Sender { get; set; }
        /// <summary>
        /// 发送时间（SendTime）
        /// </summary>
        [Required(ErrorMessage = "发送时间（SendTime）不能为空")]
        [Display( Name = "发送时间（SendTime）" )]
        [DataMember]
        public DateTime SendTime { get; set; }
        /// <summary>
        /// 业务编号（SourceId）
        /// </summary>
        [Display( Name = "业务编号（SourceId）" )]
        [DataMember]
        public Guid? SourceId { get; set; }
        /// <summary>
        /// 发送内容（Content）
        /// </summary>
        [Required(ErrorMessage = "发送内容（Content）不能为空")]
        [StringLength( 500, ErrorMessage = "发送内容（Content）输入过长，不能超过500位" )]
        [Display( Name = "发送内容（Content）" )]
        [DataMember]
        public string Content { get; set; }
        /// <summary>
        /// 业务地址（Url）
        /// </summary>
        [StringLength( 500, ErrorMessage = "业务地址（Url）输入过长，不能超过500位" )]
        [Display( Name = "业务地址（Url）" )]
        [DataMember]
        public string Url { get; set; }
        /// <summary>
        /// 消息状态（State）
        /// </summary>
        [Required(ErrorMessage = "消息状态（State）不能为空")]
        [Display( Name = "消息状态（State）" )]
        [DataMember]
        public int State { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        [Display( Name = "备注" )]
        [DataMember]
        public string Remark { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}