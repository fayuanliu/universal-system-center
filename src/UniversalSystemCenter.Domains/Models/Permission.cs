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
    /// 权限
    /// </summary>
    [DisplayName( "权限" )]
    public partial class Permission : AggregateRoot<Permission>,IDelete,IAudited {
        /// <summary>
        /// 初始化权限
        /// </summary>
        public Permission() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化权限
        /// </summary>
        /// <param name="id">权限标识</param>
        public Permission( Guid id ) : base( id ) {
            RolePermissions = new List<RolePermission>();
            UserPermissions = new List<UserPermission>();
        }

        /// <summary>
        /// 权限名称（Name)
        /// </summary>
        [DisplayName( "权限名称（Name)" )]
        [Required(ErrorMessage = "权限名称（Name)不能为空")]
        [StringLength( 50, ErrorMessage = "权限名称（Name)输入过长，不能超过50位" )]
        public string Name { get; set; }
        /// <summary>
        /// 权限点（Code）
        /// </summary>
        [DisplayName( "权限点（Code）" )]
        [Required(ErrorMessage = "权限点（Code）不能为空")]
        [StringLength( 16, ErrorMessage = "权限点（Code）输入过长，不能超过16位" )]
        public string Code { get; set; }
        /// <summary>
        /// 资源编号（ResourceId）
        /// </summary>
        [DisplayName( "资源编号（ResourceId）" )]
        public Guid? ResourceId { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [DisplayName( "启用" )]
        [Required(ErrorMessage = "启用不能为空")]
        public byte IsEnabled { get; set; }
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
        /// <summary>
        /// 资源
        /// </summary>
        [ForeignKey( "ResourceId" )]
        public Resource Resource { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Name );
            AddDescription( t => t.Code );
            AddDescription( t => t.ResourceId );
            AddDescription( t => t.IsEnabled );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.IsDeleted );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Permission other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.Code, other.Code );
            AddChange( t => t.ResourceId, other.ResourceId );
            AddChange( t => t.IsEnabled, other.IsEnabled );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.IsDeleted, other.IsDeleted );
        }
    }
}