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
    /// 消息内容表
    /// </summary>
    [DisplayName( "消息内容表" )]
    public partial class MessageContent : AggregateRoot<MessageContent>,IDelete {
        /// <summary>
        /// 初始化消息内容表
        /// </summary>
        public MessageContent() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化消息内容表
        /// </summary>
        /// <param name="id">消息内容表标识</param>
        public MessageContent( Guid id ) : base( id ) {
            Messages = new List<Message>();
        }

        /// <summary>
        /// 消息分类编号（MessageCategoryId）
        /// </summary>
        [DisplayName( "消息分类编号（MessageCategoryId）" )]
        public Guid? CategoryId { get; set; }
        /// <summary>
        /// 消息标题（Title）
        /// </summary>
        [DisplayName( "消息标题（Title）" )]
        [Required(ErrorMessage = "消息标题（Title）不能为空")]
        [StringLength( 100, ErrorMessage = "消息标题（Title）输入过长，不能超过100位" )]
        public string Title { get; set; }
        /// <summary>
        /// 发送人编号（SenderId）
        /// </summary>
        [DisplayName( "发送人编号（SenderId）" )]
        public Guid? SenderId { get; set; }
        /// <summary>
        /// 发送人（Sender)
        /// </summary>
        [DisplayName( "发送人（Sender)" )]
        [StringLength( 50, ErrorMessage = "发送人（Sender)输入过长，不能超过50位" )]
        public string Sender { get; set; }
        /// <summary>
        /// 发送时间（SendTime）
        /// </summary>
        [DisplayName( "发送时间（SendTime）" )]
        [Required(ErrorMessage = "发送时间（SendTime）不能为空")]
        public DateTime SendTime { get; set; }
        /// <summary>
        /// 业务编号（SourceId）
        /// </summary>
        [DisplayName( "业务编号（SourceId）" )]
        public Guid? SourceId { get; set; }
        /// <summary>
        /// 发送内容（Content）
        /// </summary>
        [DisplayName( "发送内容（Content）" )]
        [Required(ErrorMessage = "发送内容（Content）不能为空")]
        [StringLength( 500, ErrorMessage = "发送内容（Content）输入过长，不能超过500位" )]
        public string Content { get; set; }
        /// <summary>
        /// 业务地址（Url）
        /// </summary>
        [DisplayName( "业务地址（Url）" )]
        [StringLength( 500, ErrorMessage = "业务地址（Url）输入过长，不能超过500位" )]
        public string Url { get; set; }
        /// <summary>
        /// 消息状态（State）
        /// </summary>
        [DisplayName( "消息状态（State）" )]
        [Required(ErrorMessage = "消息状态（State）不能为空")]
        public int State { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName( "备注" )]
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        public string Remark { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [ForeignKey( "CategoryId" )]
        public MessageCategory MessageCategory { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.CategoryId );
            AddDescription( t => t.Title );
            AddDescription( t => t.SenderId );
            AddDescription( t => t.Sender );
            AddDescription( t => t.SendTime );
            AddDescription( t => t.SourceId );
            AddDescription( t => t.Content );
            AddDescription( t => t.Url );
            AddDescription( t => t.State );
            AddDescription( t => t.Remark );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( MessageContent other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.CategoryId, other.CategoryId );
            AddChange( t => t.Title, other.Title );
            AddChange( t => t.SenderId, other.SenderId );
            AddChange( t => t.Sender, other.Sender );
            AddChange( t => t.SendTime, other.SendTime );
            AddChange( t => t.SourceId, other.SourceId );
            AddChange( t => t.Content, other.Content );
            AddChange( t => t.Url, other.Url );
            AddChange( t => t.State, other.State );
            AddChange( t => t.Remark, other.Remark );
        }
    }
}