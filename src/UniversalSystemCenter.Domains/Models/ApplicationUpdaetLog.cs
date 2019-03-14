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
    /// 应用更新日志
    /// </summary>
    [DisplayName( "应用更新日志" )]
    public partial class ApplicationUpdaetLog : AggregateRoot<ApplicationUpdaetLog>,IAudited {
        /// <summary>
        /// 初始化应用更新日志
        /// </summary>
        public ApplicationUpdaetLog() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化应用更新日志
        /// </summary>
        /// <param name="id">应用更新日志标识</param>
        public ApplicationUpdaetLog( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [DisplayName( "应用程序编号（AppId）" )]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [DisplayName( "更新时间" )]
        [Required(ErrorMessage = "更新时间不能为空")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [DisplayName( "版本号" )]
        [StringLength( 50, ErrorMessage = "版本号输入过长，不能超过50位" )]
        public string VersionNO { get; set; }
        /// <summary>
        /// 更新内容
        /// </summary>
        [DisplayName( "更新内容" )]
        [StringLength( 16, ErrorMessage = "更新内容输入过长，不能超过16位" )]
        public string Content { get; set; }
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
        /// 应用程序
        /// </summary>
        [ForeignKey( "AppId" )]
        public Application Application { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.AppId );
            AddDescription( t => t.UpdateTime );
            AddDescription( t => t.VersionNO );
            AddDescription( t => t.Content );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( ApplicationUpdaetLog other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.AppId, other.AppId );
            AddChange( t => t.UpdateTime, other.UpdateTime );
            AddChange( t => t.VersionNO, other.VersionNO );
            AddChange( t => t.Content, other.Content );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}