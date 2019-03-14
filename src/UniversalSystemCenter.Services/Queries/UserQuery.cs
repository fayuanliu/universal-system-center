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
        
        private string _eId = string.Empty;
        /// <summary>
        /// 员工编号
        /// </summary>
        [Display(Name="员工编号")]
        public string EId {
            get => _eId == null ? string.Empty : _eId.Trim();
            set => _eId = value;
        }
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
        /// <summary>
        /// 账户编号
        /// </summary>
        [Display(Name="账户编号")]
        public Guid? AccountId { get; set; }
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
        /// 锁定
        /// </summary>
        [Display(Name="锁定")]
        public bool? IsLocked { get; set; }
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
    }
}