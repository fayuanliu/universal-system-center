using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace UniversalSystemCenter.Domain.Models {
    /// <summary>
    /// 账户
    /// </summary>
    [DisplayName( "账户" )]
    public partial class Account : AggregateRoot<Account>,IDelete,IAudited {
        /// <summary>
        /// 初始化账户
        /// </summary>
        public Account() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化账户
        /// </summary>
        /// <param name="id">账户标识</param>
        public Account( Guid id ) : base( id ) {
            Users = new List<User>();
        }

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
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName( "创建人" )]
        [StringLength( 36, ErrorMessage = "创建人输入过长，不能超过36位" )]
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
        [StringLength( 36, ErrorMessage = "最后修改人输入过长，不能超过36位" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        public bool IsDeleted { get; set; }

        public virtual ICollection<User> Users { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Type );
            AddDescription( t => t.State );
            AddDescription( t => t.Nickname );
            AddDescription( t => t.Password );
            AddDescription( t => t.Head );
            AddDescription( t => t.Mobile );
            AddDescription( t => t.Saltd );
            AddDescription( t => t.IdCard );
            AddDescription( t => t.RealName );
            AddDescription( t => t.Sex );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Account other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.State, other.State );
            AddChange( t => t.Nickname, other.Nickname );
            AddChange( t => t.Password, other.Password );
            AddChange( t => t.Head, other.Head );
            AddChange( t => t.Mobile, other.Mobile );
            AddChange( t => t.Saltd, other.Saltd );
            AddChange( t => t.IdCard, other.IdCard );
            AddChange( t => t.RealName, other.RealName );
            AddChange( t => t.Sex, other.Sex );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }

    public enum AccountStateEnums
    {
        /// <summary>
        /// 在用
        /// </summary>
        [Description("在用")]
        InUse,
        /// <summary>
        ///失效
        /// </summary>
        [Description("失效")]
        Invalid

    }
}