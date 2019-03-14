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
    /// 用户权限
    /// </summary>
    [DisplayName( "用户权限" )]
    public partial class UserPermission : AggregateRoot<UserPermission> {
        /// <summary>
        /// 初始化用户权限
        /// </summary>
        public UserPermission() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化用户权限
        /// </summary>
        /// <param name="id">用户权限标识</param>
        public UserPermission( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 权限编号（PermissionId）
        /// </summary>
        [DisplayName( "权限编号（PermissionId）" )]
        [Required(ErrorMessage = "权限编号（PermissionId）不能为空")]
        public Guid PermissionId { get; set; }
        /// <summary>
        /// 用户编号（UserId)
        /// </summary>
        [DisplayName( "用户编号（UserId)" )]
        [Required(ErrorMessage = "用户编号（UserId)不能为空")]
        public Guid UserId { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        [ForeignKey( "PermissionId" )]
        public Permission Permission { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        [ForeignKey( "UserId" )]
        public User User { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.PermissionId );
            AddDescription( t => t.UserId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( UserPermission other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.PermissionId, other.PermissionId );
            AddChange( t => t.UserId, other.UserId );
        }
    }
}