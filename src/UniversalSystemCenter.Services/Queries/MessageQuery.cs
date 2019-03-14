using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 消息查询参数
    /// </summary>
    public class MessageQuery : QueryParameter {
        /// <summary>
        /// 消息编号（MessageId）
        /// </summary>
        [Display(Name="消息编号（MessageId）")]
        public Guid? MessageId { get; set; }
        /// <summary>
        /// 消息内容编号（MessageContentId）
        /// </summary>
        [Display(Name="消息内容编号（MessageContentId）")]
        public Guid? MessageContentId { get; set; }
        /// <summary>
        /// 接收人（Receiver）
        /// </summary>
        [Display(Name="接收人（Receiver）")]
        public Guid? Receiver { get; set; }
        
        private string _receiverNo = string.Empty;
        /// <summary>
        /// 接收编号
        /// </summary>
        [Display(Name="接收编号")]
        public string ReceiverNo {
            get => _receiverNo == null ? string.Empty : _receiverNo.Trim();
            set => _receiverNo = value;
        }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [Display(Name="状态（State）")]
        public int? State { get; set; }
        
        private string _errorMsg = string.Empty;
        /// <summary>
        /// 错误信息
        /// </summary>
        [Display(Name="错误信息")]
        public string ErrorMsg {
            get => _errorMsg == null ? string.Empty : _errorMsg.Trim();
            set => _errorMsg = value;
        }
        /// <summary>
        /// 起始查看时间（ReadTime）
        /// </summary>
        [Display( Name = "起始查看时间（ReadTime）" )]
        public DateTime? BeginReadTime { get; set; }
        /// <summary>
        /// 结束查看时间（ReadTime）
        /// </summary>
        [Display( Name = "结束查看时间（ReadTime）" )]
        public DateTime? EndReadTime { get; set; }
        /// <summary>
        /// 起始发送时间（SendTime）
        /// </summary>
        [Display( Name = "起始发送时间（SendTime）" )]
        public DateTime? BeginSendTime { get; set; }
        /// <summary>
        /// 结束发送时间（SendTime）
        /// </summary>
        [Display( Name = "结束发送时间（SendTime）" )]
        public DateTime? EndSendTime { get; set; }
    }
}