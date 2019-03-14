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
    /// 角色
    /// </summary>
    [DisplayName( "角色" )]
    public partial class Role : AggregateRoot<Role>,IDelete,IAudited {
        /// <summary>
        /// 初始化角色
        /// </summary>
        public Role() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化角色
        /// </summary>
        /// <param name="id">角色标识</param>
        public Role( Guid id ) : base( id ) {
            RoleMenus = new List<RoleMenu>();
            RolePermissions = new List<RolePermission>();
            UserRoles = new List<UserRole>();
        }

        /// <summary>
        /// 名称（Name）
        /// </summary>
        [DisplayName( "名称（Name）" )]
        [StringLength( 100, ErrorMessage = "名称（Name）输入过长，不能超过100位" )]
        public string Name { get; set; }
        /// <summary>
        /// 值（Values)
        /// </summary>
        [DisplayName( "值（Values)" )]
        [StringLength( 16, ErrorMessage = "值（Values)输入过长，不能超过16位" )]
        public string Values { get; set; }
        /// <summary>
        /// 图标（Icon）
        /// </summary>
        [DisplayName( "图标（Icon）" )]
        [StringLength( 100, ErrorMessage = "图标（Icon）输入过长，不能超过100位" )]
        public string Icon { get; set; }
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
        /// 商户编号
        /// </summary>
        [DisplayName( "商户编号" )]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 商户
        /// </summary>
        [ForeignKey( "MerchantId" )]
        public Merchant Merchant { get; set; }

        public virtual ICollection<RoleMenu> RoleMenus { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Name );
            AddDescription( t => t.Values );
            AddDescription( t => t.Icon );
            AddDescription( t => t.IsEnabled );
            AddDescription( t => t.SortId );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
            AddDescription( t => t.IsDeleted );
            AddDescription( t => t.MerchantId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Role other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.Values, other.Values );
            AddChange( t => t.Icon, other.Icon );
            AddChange( t => t.IsEnabled, other.IsEnabled );
            AddChange( t => t.SortId, other.SortId );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
            AddChange( t => t.IsDeleted, other.IsDeleted );
            AddChange( t => t.MerchantId, other.MerchantId );
        }
    }
}