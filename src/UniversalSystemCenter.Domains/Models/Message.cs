using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 消息
    /// </summary>
    [DisplayName( "消息" )]
    public partial class Message : AggregateRoot<Message>,IDelete {
        /// <summary>
        /// 初始化消息
        /// </summary>
        public Message() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化消息
        /// </summary>
        /// <param name="id">消息标识</param>
        public Message( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 消息内容编号（MessageContentId）
        /// </summary>
        [DisplayName( "消息内容编号（MessageContentId）" )]
        [Required(ErrorMessage = "消息内容编号（MessageContentId）不能为空")]
        public Guid MessageContentId { get; set; }
        /// <summary>
        /// 接收人（Receiver）
        /// </summary>
        [DisplayName( "接收人（Receiver）" )]
        [Required(ErrorMessage = "接收人（Receiver）不能为空")]
        public Guid Receiver { get; set; }
        /// <summary>
        /// 接收编号
        /// </summary>
        [DisplayName( "接收编号" )]
        [StringLength( 50, ErrorMessage = "接收编号输入过长，不能超过50位" )]
        public string ReceiverNo { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [DisplayName( "状态（State）" )]
        [Required(ErrorMessage = "状态（State）不能为空")]
        public int State { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        [DisplayName( "错误信息" )]
        [StringLength( 5000, ErrorMessage = "错误信息输入过长，不能超过5000位" )]
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 查看时间（ReadTime）
        /// </summary>
        [DisplayName( "查看时间（ReadTime）" )]
        public DateTime? ReadTime { get; set; }
        /// <summary>
        /// 发送时间（SendTime）
        /// </summary>
        [DisplayName( "发送时间（SendTime）" )]
        public DateTime? SendTime { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 消息内容表
        /// </summary>
        [ForeignKey( "MessageContentId" )]
        public MessageContent MessageContent { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.MessageContentId );
            AddDescription( t => t.Receiver );
            AddDescription( t => t.ReceiverNo );
            AddDescription( t => t.State );
            AddDescription( t => t.ErrorMsg );
            AddDescription( t => t.ReadTime );
            AddDescription( t => t.SendTime );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Message other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.MessageContentId, other.MessageContentId );
            AddChange( t => t.Receiver, other.Receiver );
            AddChange( t => t.ReceiverNo, other.ReceiverNo );
            AddChange( t => t.State, other.State );
            AddChange( t => t.ErrorMsg, other.ErrorMsg );
            AddChange( t => t.ReadTime, other.ReadTime );
            AddChange( t => t.SendTime, other.SendTime );
        }
    }
}