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
    /// 用户
    /// </summary>
    [DisplayName( "用户" )]
    public partial class User : AggregateRoot<User>,IDelete,IAudited {
        /// <summary>
        /// 初始化用户
        /// </summary>
        public User() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化用户
        /// </summary>
        /// <param name="id">用户标识</param>
        public User( Guid id ) : base( id ) {
            UserPermissions = new List<UserPermission>();
            UserPositions = new List<UserPosition>();
            UserRoles = new List<UserRole>();
        }

        /// <summary>
        /// 员工编号
        /// </summary>
        [DisplayName( "员工编号" )]
        [StringLength( 50, ErrorMessage = "员工编号输入过长，不能超过50位" )]
        public string EId { get; set; }
        /// <summary>
        /// 组织机构编号(OrganizationsId)
        /// </summary>
        [DisplayName( "组织机构编号(OrganizationsId)" )]
        public Guid? OrganizationsId { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [DisplayName( "商户编号" )]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 账户编号
        /// </summary>
        [DisplayName( "账户编号" )]
        public Guid? AccountId { get; set; }
        /// <summary>
        /// 注册日期（RegisterTime）
        /// </summary>
        [DisplayName( "注册日期（RegisterTime）" )]
        [Required(ErrorMessage = "注册日期（RegisterTime）不能为空")]
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 锁定
        /// </summary>
        [DisplayName( "锁定" )]
        public bool IsLocked { get; set; }
        /// <summary>
        /// 锁定起始时间
        /// </summary>
        [DisplayName( "锁定起始时间" )]
        public DateTime? LockBeginTime { get; set; }
        /// <summary>
        /// 锁定持续时间
        /// </summary>
        [DisplayName( "锁定持续时间" )]
        public int? LockDuration { get; set; }
        /// <summary>
        /// 锁定提示消息
        /// </summary>
        [DisplayName( "锁定提示消息" )]
        [StringLength( 100, ErrorMessage = "锁定提示消息输入过长，不能超过100位" )]
        public string LockMessage { get; set; }
        /// <summary>
        /// 上次登陆时间
        /// </summary>
        [DisplayName( "上次登陆时间" )]
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 上次登陆Ip
        /// </summary>
        [DisplayName( "上次登陆Ip" )]
        [StringLength( 30, ErrorMessage = "上次登陆Ip输入过长，不能超过30位" )]
        public string LastLoginIp { get; set; }
        /// <summary>
        /// 本次登陆时间
        /// </summary>
        [DisplayName( "本次登陆时间" )]
        public DateTime? CurrentLoginTime { get; set; }
        /// <summary>
        /// 本次登陆Ip
        /// </summary>
        [DisplayName( "本次登陆Ip" )]
        [StringLength( 30, ErrorMessage = "本次登陆Ip输入过长，不能超过30位" )]
        public string CurrentLoginIp { get; set; }
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
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 商户
        /// </summary>
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }
        /// <summary>
        /// 组织机构
        /// </summary>
        [ForeignKey("OrganizationsId")]
        public Organizations Organizations { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        [ForeignKey( "AccountId" )]
        public Account Account { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }

        public virtual ICollection<UserPosition> UserPositions { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }


        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.EId );
            AddDescription( t => t.OrganizationsId );
            AddDescription( t => t.MerchantId );
            AddDescription( t => t.AccountId );
            AddDescription( t => t.RegisterTime );
            AddDescription( t => t.IsLocked );
            AddDescription( t => t.LockBeginTime );
            AddDescription( t => t.LockDuration );
            AddDescription( t => t.LockMessage );
            AddDescription( t => t.LastLoginTime );
            AddDescription( t => t.LastLoginIp );
            AddDescription( t => t.CurrentLoginTime );
            AddDescription( t => t.CurrentLoginIp );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( User other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.EId, other.EId );
            AddChange( t => t.OrganizationsId, other.OrganizationsId );
            AddChange( t => t.MerchantId, other.MerchantId );
            AddChange( t => t.AccountId, other.AccountId );
            AddChange( t => t.RegisterTime, other.RegisterTime );
            AddChange( t => t.IsLocked, other.IsLocked );
            AddChange( t => t.LockBeginTime, other.LockBeginTime );
            AddChange( t => t.LockDuration, other.LockDuration );
            AddChange( t => t.LockMessage, other.LockMessage );
            AddChange( t => t.LastLoginTime, other.LastLoginTime );
            AddChange( t => t.LastLoginIp, other.LastLoginIp );
            AddChange( t => t.CurrentLoginTime, other.CurrentLoginTime );
            AddChange( t => t.CurrentLoginIp, other.CurrentLoginIp );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}