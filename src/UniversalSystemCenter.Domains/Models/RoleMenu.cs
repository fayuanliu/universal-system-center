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
    /// 角色菜单
    /// </summary>
    [DisplayName( "角色菜单" )]
    public partial class RoleMenu : AggregateRoot<RoleMenu> {
        /// <summary>
        /// 初始化角色菜单
        /// </summary>
        public RoleMenu() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化角色菜单
        /// </summary>
        /// <param name="id">角色菜单标识</param>
        public RoleMenu( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 菜单编号（MenuId)
        /// </summary>
        [DisplayName( "菜单编号（MenuId)" )]
        [Required(ErrorMessage = "菜单编号（MenuId)不能为空")]
        public Guid MenuId { get; set; }
        /// <summary>
        /// 类型编号（TypeId）
        /// </summary>
        [DisplayName( "类型编号（TypeId）" )]
        [Required(ErrorMessage = "类型编号（TypeId）不能为空")]
        public Guid RoleId { get; set; }
        /// <summary>
        /// 是否半选（Half）
        /// </summary>
        [DisplayName( "是否半选（Half）" )]
        [Required(ErrorMessage = "是否半选（Half）不能为空")]
        public byte Half { get; set; }
        /// <summary>
        /// 菜单
        /// </summary>
        [ForeignKey( "MenuId" )]
        public Menu Menu { get; set; }
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
            AddDescription( t => t.MenuId );
            AddDescription( t => t.RoleId );
            AddDescription( t => t.Half );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( RoleMenu other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.MenuId, other.MenuId );
            AddChange( t => t.RoleId, other.RoleId );
            AddChange( t => t.Half, other.Half );
        }
    }
}