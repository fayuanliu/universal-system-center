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
        /// 用户名称（UserName）
        /// </summary>
        [DisplayName( "用户名称（UserName）" )]
        [Required(ErrorMessage = "用户名称（UserName）不能为空")]
        [StringLength( 100, ErrorMessage = "用户名称（UserName）输入过长，不能超过100位" )]
        public string Account { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [DisplayName( "昵称" )]
        [StringLength( 100, ErrorMessage = "昵称输入过长，不能超过100位" )]
        public string Nickname { get; set; }
        /// <summary>
        /// 密码（Password）
        /// </summary>
        [DisplayName( "密码（Password）" )]
        [StringLength( 100, ErrorMessage = "密码（Password）输入过长，不能超过100位" )]
        public string Password { get; set; }
        /// <summary>
        /// 头像（Head）
        /// </summary>
        [DisplayName( "头像（Head）" )]
        [StringLength( 200, ErrorMessage = "头像（Head）输入过长，不能超过200位" )]
        public string Head { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [DisplayName( "手机号" )]
        [StringLength( 20, ErrorMessage = "手机号输入过长，不能超过20位" )]
        public string Mobile { get; set; }
        /// <summary>
        /// 注册日期（RegisterTime）
        /// </summary>
        [DisplayName( "注册日期（RegisterTime）" )]
        [Required(ErrorMessage = "注册日期（RegisterTime）不能为空")]
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [DisplayName( "类型" )]
        [Required(ErrorMessage = "类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName( "状态" )]
        [Required(ErrorMessage = "状态不能为空")]
        public int State { get; set; }
        /// <summary>
        /// 盐值
        /// </summary>
        [DisplayName( "盐值" )]
        [StringLength( 10, ErrorMessage = "盐值输入过长，不能超过10位" )]
        public string Saltd { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        [DisplayName( "用户编号" )]
        [StringLength( 18, ErrorMessage = "用户编号输入过长，不能超过18位" )]
        public string IdCard { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [DisplayName( "真实姓名" )]
        [StringLength( 20, ErrorMessage = "真实姓名输入过长，不能超过20位" )]
        public string RealName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [DisplayName( "性别" )]
        [Required(ErrorMessage = "性别不能为空")]
        public int Sex { get; set; }
        /// <summary>
        /// 推荐人
        /// </summary>
        [DisplayName( "推荐人" )]
        public Guid? Referrer { get; set; }
        /// <summary>
        /// 锁定
        /// </summary>
        [DisplayName( "锁定" )]
        [Required(ErrorMessage = "锁定不能为空")]
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
        [Required(ErrorMessage = "是否删除不能为空")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 商户
        /// </summary>
        [ForeignKey( "MerchantId" )]
        public Merchant Merchant { get; set; }
        /// <summary>
        /// 组织机构
        /// </summary>
        [ForeignKey( "OrganizationsId" )]
        public Organizations Organizations { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }

        public virtual ICollection<UserPosition> UserPositions { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.OrganizationsId );
            AddDescription( t => t.MerchantId );
            AddDescription( t => t.Account );
            AddDescription( t => t.Nickname );
            AddDescription( t => t.Password );
            AddDescription( t => t.Head );
            AddDescription( t => t.Mobile );
            AddDescription( t => t.RegisterTime );
            AddDescription( t => t.Type );
            AddDescription( t => t.State );
            AddDescription( t => t.Saltd );
            AddDescription( t => t.IdCard );
            AddDescription( t => t.RealName );
            AddDescription( t => t.Sex );
            AddDescription( t => t.Referrer );
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
            AddDescription( t => t.IsDeleted );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( User other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.OrganizationsId, other.OrganizationsId );
            AddChange( t => t.MerchantId, other.MerchantId );
            AddChange( t => t.Account, other.Account );
            AddChange( t => t.Nickname, other.Nickname );
            AddChange( t => t.Password, other.Password );
            AddChange( t => t.Head, other.Head );
            AddChange( t => t.Mobile, other.Mobile );
            AddChange( t => t.RegisterTime, other.RegisterTime );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.State, other.State );
            AddChange( t => t.Saltd, other.Saltd );
            AddChange( t => t.IdCard, other.IdCard );
            AddChange( t => t.RealName, other.RealName );
            AddChange( t => t.Sex, other.Sex );
            AddChange( t => t.Referrer, other.Referrer );
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
            AddChange( t => t.IsDeleted, other.IsDeleted );
        }
    }

    public enum UserStateEnums
    {
        /// <summary>
        /// 在用
        /// </summary>
        [Description("在用")]
        InUse,
        /// <summary>
        /// 失效
        /// </summary>
        [Description("失效")]
        Invalid
    }
}