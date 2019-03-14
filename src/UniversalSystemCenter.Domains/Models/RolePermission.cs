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
    /// 角色权限
    /// </summary>
    [DisplayName( "角色权限" )]
    public partial class RolePermission : AggregateRoot<RolePermission> {
        /// <summary>
        /// 初始化角色权限
        /// </summary>
        public RolePermission() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化角色权限
        /// </summary>
        /// <param name="id">角色权限标识</param>
        public RolePermission( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [DisplayName( "类型编号（TypeId）" )]
        [Required(ErrorMessage = "类型编号（TypeId）不能为空")]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 权限编号（PermissionId）
        /// </summary>
        [DisplayName( "权限编号（PermissionId）" )]
        [Required(ErrorMessage = "权限编号（PermissionId）不能为空")]
        public Guid PermissionId { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        [ForeignKey( "PermissionId" )]
        public Permission Permission { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        [ForeignKey( "RoleId" )]
        public Role Role { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.RoleId );
            AddDescription( t => t.PermissionId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( RolePermission other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.RoleId, other.RoleId );
            AddChange( t => t.PermissionId, other.PermissionId );
        }
    }
}