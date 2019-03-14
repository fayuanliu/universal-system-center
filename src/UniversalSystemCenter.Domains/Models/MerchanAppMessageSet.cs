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
    /// 商户应用消息设置
    /// </summary>
    [DisplayName( "商户应用消息设置" )]
    public partial class MerchanAppMessageSet : AggregateRoot<MerchanAppMessageSet>,IDelete {
        /// <summary>
        /// 初始化商户应用消息设置
        /// </summary>
        public MerchanAppMessageSet() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化商户应用消息设置
        /// </summary>
        /// <param name="id">商户应用消息设置标识</param>
        public MerchanAppMessageSet( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 消息分类编号（MessageCategoryId）
        /// </summary>
        [DisplayName( "消息分类编号（MessageCategoryId）" )]
        public Guid? CategoryId { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [DisplayName( "消息类型" )]
        [Required(ErrorMessage = "消息类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [DisplayName( "状态（State）" )]
        [Required(ErrorMessage = "状态（State）不能为空")]
        public int State { get; set; }
        /// <summary>
        /// 会员（MemberId）
        /// </summary>
        [DisplayName( "会员（MemberId）" )]
        [Required(ErrorMessage = "会员（MemberId）不能为空")]
        public Guid MerchanId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [ForeignKey( "CategoryId" )]
        public MessageCategory MessageCategory { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.CategoryId );
            AddDescription( t => t.Type );
            AddDescription( t => t.State );
            AddDescription( t => t.MerchanId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( MerchanAppMessageSet other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.CategoryId, other.CategoryId );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.State, other.State );
            AddChange( t => t.MerchanId, other.MerchanId );
        }
    }
}