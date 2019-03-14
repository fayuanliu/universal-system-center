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
    /// 消息模板
    /// </summary>
    [DisplayName( "消息模板" )]
    public partial class MessageTemplate : AggregateRoot<MessageTemplate>,IDelete,IAudited {
        /// <summary>
        /// 初始化消息模板
        /// </summary>
        public MessageTemplate() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化消息模板
        /// </summary>
        /// <param name="id">消息模板标识</param>
        public MessageTemplate( Guid id ) : base( id ) {
            MessageContents = new List<MessageContent>();
        }

        /// <summary>
        /// 所属消息分类
        /// </summary>
        [DisplayName( "所属消息分类" )]
        [Required(ErrorMessage = "所属消息分类不能为空")]
        public Guid CategoryId { get; set; }
        /// <summary>
        /// 模板类型
        /// </summary>
        [DisplayName( "模板类型" )]
        [Required(ErrorMessage = "模板类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 模板编码
        /// </summary>
        [DisplayName( "模板编码" )]
        public Guid? SendObject { get; set; }
        /// <summary>
        /// 模板名称
        /// </summary>
        [DisplayName( "模板名称" )]
        [Required(ErrorMessage = "模板名称不能为空")]
        [StringLength( 50, ErrorMessage = "模板名称输入过长，不能超过50位" )]
        public string Name { get; set; }
        /// <summary>
        /// 资源编号
        /// </summary>
        [DisplayName( "资源编号" )]
        [StringLength( 200, ErrorMessage = "资源编号输入过长，不能超过200位" )]
        public string SourceId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [DisplayName( "标题" )]
        [StringLength( 50, ErrorMessage = "标题输入过长，不能超过50位" )]
        public string Title { get; set; }
        /// <summary>
        /// 模板内容
        /// </summary>
        [DisplayName( "模板内容" )]
        [StringLength( 16, ErrorMessage = "模板内容输入过长，不能超过16位" )]
        public string Content { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [DisplayName( "启用" )]
        [Required(ErrorMessage = "启用不能为空")]
        public byte IsEnabled { get; set; }
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
        /// 最后修改人
        /// </summary>
        [DisplayName( "最后修改人" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName( "最后修改时间" )]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [ForeignKey( "CategoryId" )]
        public MessageCategory MessageCategory { get; set; }

        public virtual ICollection<MessageContent> MessageContents { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.CategoryId );
            AddDescription( t => t.Type );
            AddDescription( t => t.SendObject );
            AddDescription( t => t.Name );
            AddDescription( t => t.SourceId );
            AddDescription( t => t.Title );
            AddDescription( t => t.Content );
            AddDescription( t => t.IsEnabled );
            AddDescription( t => t.SortId );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.IsDeleted );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( MessageTemplate other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.CategoryId, other.CategoryId );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.SendObject, other.SendObject );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.SourceId, other.SourceId );
            AddChange( t => t.Title, other.Title );
            AddChange( t => t.Content, other.Content );
            AddChange( t => t.IsEnabled, other.IsEnabled );
            AddChange( t => t.SortId, other.SortId );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.IsDeleted, other.IsDeleted );
        }
    }
}