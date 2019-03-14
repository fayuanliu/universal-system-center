using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Trees;
using Util.Domains.Auditing;
using Util.Domains.Tenants;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 资源
    /// </summary>
    [Description( "资源" )]
    public partial class Resource : TreeEntityBase<Resource>,IDelete,IAudited {
        /// <summary>
        /// 初始化资源
        /// </summary>
        public Resource()
            : this( Guid.Empty, "", 0 ) {
        }

        /// <summary>
        /// 初始化资源
        /// </summary>
        /// <param name="id">资源标识</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        public Resource( Guid id, string path, int level )
            : base( id, path, level ) {
            Permissions = new List<Permission>();
        }

        /// <summary>
        /// 资源标识
        /// </summary>
        [StringLength( 500, ErrorMessage = "资源标识输入过长，不能超过500位" )]
        public string Uri { get; set; }
        /// <summary>
        /// 资源名称
        /// </summary>
        [Required(ErrorMessage = "资源名称不能为空")]
        [StringLength( 50, ErrorMessage = "资源名称输入过长，不能超过50位" )]
        public string Name { get; set; }
        /// <summary>
        /// 资源类型
        /// </summary>
        [Required(ErrorMessage = "资源类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        public string Note { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        public bool IsLeave { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// PinYin
        /// </summary>
        [Required(ErrorMessage = "PinYin不能为空")]
        [StringLength( 50, ErrorMessage = "PinYin输入过长，不能超过50位" )]
        public string PinYin { get; set; }
        /// <summary>
        /// AppId
        /// </summary>
        public Guid? AppId { get; set; }
        /// <summary>
        /// 应用程序
        /// </summary>
        [ForeignKey( "AppId" )]
        public Application Application { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Uri );
            AddDescription( t => t.Name );
            AddDescription( t => t.Type );
            AddDescription( t => t.Note );
            AddDescription( t => t.IsLeave );
            AddDescription( t => t.ParentId );
            AddDescription( t => t.Path );
            AddDescription( t => t.Level );
            AddDescription( t => t.SortId );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.IsDeleted );
            AddDescription( t => t.PinYin );
            AddDescription( t => t.Enabled );
            AddDescription( t => t.AppId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Resource other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Uri, other.Uri );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.Note, other.Note );
            AddChange( t => t.IsLeave, other.IsLeave );
            AddChange( t => t.ParentId, other.ParentId );
            AddChange( t => t.Path, other.Path );
            AddChange( t => t.Level, other.Level );
            AddChange( t => t.SortId, other.SortId );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.IsDeleted, other.IsDeleted );
            AddChange( t => t.PinYin, other.PinYin );
            AddChange( t => t.Enabled, other.Enabled );
            AddChange( t => t.AppId, other.AppId );
        }
    }
}