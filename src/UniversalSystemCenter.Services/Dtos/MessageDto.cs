using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 消息数据传输对象
    /// </summary>
    
    public class MessageDto : DtoBase {
        /// <summary>
        /// 消息内容编号（MessageContentId）
        /// </summary>
        [Required(ErrorMessage = "消息内容编号（MessageContentId）不能为空")]
        [Display( Name = "消息内容编号（MessageContentId）" )]
        [DataMember]
        public Guid MessageContentId { get; set; }
        /// <summary>
        /// 接收人（Receiver）
        /// </summary>
        [Required(ErrorMessage = "接收人（Receiver）不能为空")]
        [Display( Name = "接收人（Receiver）" )]
        [DataMember]
        public Guid Receiver { get; set; }
        /// <summary>
        /// 接收编号
        /// </summary>
        [StringLength( 50, ErrorMessage = "接收编号输入过长，不能超过50位" )]
        [Display( Name = "接收编号" )]
        [DataMember]
        public string ReceiverNo { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [Required(ErrorMessage = "状态（State）不能为空")]
        [Display( Name = "状态（State）" )]
        [DataMember]
        public int State { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        [StringLength( 5000, ErrorMessage = "错误信息输入过长，不能超过5000位" )]
        [Display( Name = "错误信息" )]
        [DataMember]
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 查看时间（ReadTime）
        /// </summary>
        [Display( Name = "查看时间（ReadTime）" )]
        [DataMember]
        public DateTime? ReadTime { get; set; }
        /// <summary>
        /// 发送时间（SendTime）
        /// </summary>
        [Display( Name = "发送时间（SendTime）" )]
        [DataMember]
        public DateTime? SendTime { get; set; }
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