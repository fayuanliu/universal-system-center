using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 用户查询参数
    /// </summary>
    public class UserQuery : QueryParameter {
        /// <summary>
        /// 用户编号（UserId)
        /// </summary>
        [Display(Name="用户编号（UserId)")]
        public Guid? UserId { get; set; }
        /// <summary>
        /// 组织机构编号(OrganizationsId)
        /// </summary>
        [Display(Name="组织机构编号(OrganizationsId)")]
        public Guid? OrganizationsId { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display(Name="商户编号")]
        public Guid? MerchantId { get; set; }
        
        private string _account = string.Empty;
        /// <summary>
        /// 用户名称（UserName）
        /// </summary>
        [Display(Name="用户名称（UserName）")]
        public string Account {
            get => _account == null ? string.Empty : _account.Trim();
            set => _account = value;
        }
        
        private string _nickname = string.Empty;
        /// <summary>
        /// 昵称
        /// </summary>
        [Display(Name="昵称")]
        public string Nickname {
            get => _nickname == null ? string.Empty : _nickname.Trim();
            set => _nickname = value;
        }
        
        private string _password = string.Empty;
        /// <summary>
        /// 密码（Password）
        /// </summary>
        [Display(Name="密码（Password）")]
        public string Password {
            get => _password == null ? string.Empty : _password.Trim();
            set => _password = value;
        }
        
        private string _head = string.Empty;
        /// <summary>
        /// 头像（Head）
        /// </summary>
        [Display(Name="头像（Head）")]
        public string Head {
            get => _head == null ? string.Empty : _head.Trim();
            set => _head = value;
        }
        
        private string _mobile = string.Empty;
        /// <summary>
        /// 手机号
        /// </summary>
        [Display(Name="手机号")]
        public string Mobile {
            get => _mobile == null ? string.Empty : _mobile.Trim();
            set => _mobile = value;
        }
        /// <summary>
        /// 起始注册日期（RegisterTime）
        /// </summary>
        [Display( Name = "起始注册日期（RegisterTime）" )]
        public DateTime? BeginRegisterTime { get; set; }
        /// <summary>
        /// 结束注册日期（RegisterTime）
        /// </summary>
        [Display( Name = "结束注册日期（RegisterTime）" )]
        public DateTime? EndRegisterTime { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name="类型")]
        public int? Type { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? State { get; set; }
        
        private string _saltd = string.Empty;
        /// <summary>
        /// 盐值
        /// </summary>
        [Display(Name="盐值")]
        public string Saltd {
            get => _saltd == null ? string.Empty : _saltd.Trim();
            set => _saltd = value;
        }
        
        private string _idCard = string.Empty;
        /// <summary>
        /// 用户编号
        /// </summary>
        [Display(Name="用户编号")]
        public string IdCard {
            get => _idCard == null ? string.Empty : _idCard.Trim();
            set => _idCard = value;
        }
        
        private string _realName = string.Empty;
        /// <summary>
        /// 真实姓名
        /// </summary>
        [Display(Name="真实姓名")]
        public string RealName {
            get => _realName == null ? string.Empty : _realName.Trim();
            set => _realName = value;
        }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name="性别")]
        public int? Sex { get; set; }
        /// <summary>
        /// 推荐人
        /// </summary>
        [Display(Name="推荐人")]
        public Guid? Referrer { get; set; }
        /// <summary>
        /// 锁定
        /// </summary>
        [Display(Name="锁定")]
        public byte? IsLocked { get; set; }
        /// <summary>
        /// 起始锁定起始时间
        /// </summary>
        [Display( Name = "起始锁定起始时间" )]
        public DateTime? BeginLockBeginTime { get; set; }
        /// <summary>
        /// 结束锁定起始时间
        /// </summary>
        [Display( Name = "结束锁定起始时间" )]
        public DateTime? EndLockBeginTime { get; set; }
        /// <summary>
        /// 锁定持续时间
        /// </summary>
        [Display(Name="锁定持续时间")]
        public int? LockDuration { get; set; }
        
        private string _lockMessage = string.Empty;
        /// <summary>
        /// 锁定提示消息
        /// </summary>
        [Display(Name="锁定提示消息")]
        public string LockMessage {
            get => _lockMessage == null ? string.Empty : _lockMessage.Trim();
            set => _lockMessage = value;
        }
        /// <summary>
        /// 起始上次登陆时间
        /// </summary>
        [Display( Name = "起始上次登陆时间" )]
        public DateTime? BeginLastLoginTime { get; set; }
        /// <summary>
        /// 结束上次登陆时间
        /// </summary>
        [Display( Name = "结束上次登陆时间" )]
        public DateTime? EndLastLoginTime { get; set; }
        
        private string _lastLoginIp = string.Empty;
        /// <summary>
        /// 上次登陆Ip
        /// </summary>
        [Display(Name="上次登陆Ip")]
        public string LastLoginIp {
            get => _lastLoginIp == null ? string.Empty : _lastLoginIp.Trim();
            set => _lastLoginIp = value;
        }
        /// <summary>
        /// 起始本次登陆时间
        /// </summary>
        [Display( Name = "起始本次登陆时间" )]
        public DateTime? BeginCurrentLoginTime { get; set; }
        /// <summary>
        /// 结束本次登陆时间
        /// </summary>
        [Display( Name = "结束本次登陆时间" )]
        public DateTime? EndCurrentLoginTime { get; set; }
        
        private string _currentLoginIp = string.Empty;
        /// <summary>
        /// 本次登陆Ip
        /// </summary>
        [Display(Name="本次登陆Ip")]
        public string CurrentLoginIp {
            get => _currentLoginIp == null ? string.Empty : _currentLoginIp.Trim();
            set => _currentLoginIp = value;
        }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display( Name = "起始最后修改时间" )]
        public DateTime? BeginLastModificationTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display( Name = "结束最后修改时间" )]
        public DateTime? EndLastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display(Name="最后修改人")]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name="是否删除")]
        public byte? IsDeleted { get; set; }
    }
}