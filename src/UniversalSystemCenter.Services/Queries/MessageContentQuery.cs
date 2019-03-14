using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 消息内容表查询参数
    /// </summary>
    public class MessageContentQuery : QueryParameter {
        /// <summary>
        /// 消息内容编号（MessageContentId）
        /// </summary>
        [Display(Name="消息内容编号（MessageContentId）")]
        public Guid? MessageContentId { get; set; }
        /// <summary>
        /// 消息分类编号（MessageCategoryId）
        /// </summary>
        [Display(Name="消息分类编号（MessageCategoryId）")]
        public Guid? CategoryId { get; set; }
        
        private string _title = string.Empty;
        /// <summary>
        /// 消息标题（Title）
        /// </summary>
        [Display(Name="消息标题（Title）")]
        public string Title {
            get => _title == null ? string.Empty : _title.Trim();
            set => _title = value;
        }
        /// <summary>
        /// 发送人编号（SenderId）
        /// </summary>
        [Display(Name="发送人编号（SenderId）")]
        public Guid? SenderId { get; set; }
        
        private string _sender = string.Empty;
        /// <summary>
        /// 发送人（Sender)
        /// </summary>
        [Display(Name="发送人（Sender)")]
        public string Sender {
            get => _sender == null ? string.Empty : _sender.Trim();
            set => _sender = value;
        }
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
        /// <summary>
        /// 业务编号（SourceId）
        /// </summary>
        [Display(Name="业务编号（SourceId）")]
        public Guid? SourceId { get; set; }
        
        private string _content = string.Empty;
        /// <summary>
        /// 发送内容（Content）
        /// </summary>
        [Display(Name="发送内容（Content）")]
        public string Content {
            get => _content == null ? string.Empty : _content.Trim();
            set => _content = value;
        }
        
        private string _url = string.Empty;
        /// <summary>
        /// 业务地址（Url）
        /// </summary>
        [Display(Name="业务地址（Url）")]
        public string Url {
            get => _url == null ? string.Empty : _url.Trim();
            set => _url = value;
        }
        /// <summary>
        /// 消息状态（State）
        /// </summary>
        [Display(Name="消息状态（State）")]
        public int? State { get; set; }
        
        private string _remark = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name="备注")]
        public string Remark {
            get => _remark == null ? string.Empty : _remark.Trim();
            set => _remark = value;
        }
    }
}