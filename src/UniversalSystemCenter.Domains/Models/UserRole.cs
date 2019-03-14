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
    /// 用户角色
    /// </summary>
    [DisplayName( "用户角色" )]
    public partial class UserRole : AggregateRoot<UserRole> {
        /// <summary>
        /// 初始化用户角色
        /// </summary>
        public UserRole() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化用户角色
        /// </summary>
        /// <param name="id">用户角色标识</param>
        public UserRole( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [DisplayName( "类型编号（TypeId）" )]
        [Required(ErrorMessage = "类型编号（TypeId）不能为空")]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 用户编号（UserId)
        /// </summary>
        [DisplayName( "用户编号（UserId)" )]
        [Required(ErrorMessage = "用户编号（UserId)不能为空")]
        public Guid UserId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        [ForeignKey( "RoleId" )]
        public Role Role { get; set; }
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
            AddDescription( t => t.RoleId );
            AddDescription( t => t.UserId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( UserRole other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.RoleId, other.RoleId );
            AddChange( t => t.UserId, other.UserId );
        }
    }
}