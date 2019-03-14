using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 消息类型
    /// </summary>
    [DisplayName( "消息类型" )]
    public partial class MessageCategory : AggregateRoot<MessageCategory>,IDelete,IAudited {
        /// <summary>
        /// 初始化消息类型
        /// </summary>
        public MessageCategory() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化消息类型
        /// </summary>
        /// <param name="id">消息类型标识</param>
        public MessageCategory( Guid id ) : base( id ) {
            MerchanAppMessageSets = new List<MerchanAppMessageSet>();
            MessageTemplates = new List<MessageTemplate>();
        }

        /// <summary>
        /// 分类名称
        /// </summary>
        [DisplayName( "分类名称" )]
        [Required(ErrorMessage = "分类名称不能为空")]
        [StringLength( 500, ErrorMessage = "分类名称输入过长，不能超过500位" )]
        public string Name { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [DisplayName( "启用" )]
        [Required(ErrorMessage = "启用不能为空")]
        public byte IsEnabled { get; set; }
        /// <summary>
        /// 消息类型(通知、代办)
        /// </summary>
        [DisplayName( "消息类型(通知、代办)" )]
        [Required(ErrorMessage = "消息类型(通知、代办)不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 所属平台
        /// </summary>
        [DisplayName( "所属平台" )]
        [Required(ErrorMessage = "所属平台不能为空")]
        public int AppId { get; set; }
        /// <summary>
        /// 模块
        /// </summary>
        [DisplayName( "模块" )]
        [StringLength( 500, ErrorMessage = "模块输入过长，不能超过500位" )]
        public string Module { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [DisplayName( "排序号" )]
        [Required(ErrorMessage = "排序号不能为空")]
        public int SortId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName( "创建人" )]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName( "最后修改时间" )]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [DisplayName( "最后修改人" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }

        public virtual ICollection<MerchanAppMessageSet> MerchanAppMessageSets { get; set; }

        public virtual ICollection<MessageTemplate> MessageTemplates { get; set; }


        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Name );
            AddDescription( t => t.IsEnabled );
            AddDescription( t => t.Type );
            AddDescription( t => t.AppId );
            AddDescription( t => t.Module );
            AddDescription( t => t.SortId );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.IsDeleted );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( MessageCategory other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.IsEnabled, other.IsEnabled );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.AppId, other.AppId );
            AddChange( t => t.Module, other.Module );
            AddChange( t => t.SortId, other.SortId );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.IsDeleted, other.IsDeleted );
        }
    }
}