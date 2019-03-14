using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 用户数据传输对象
    /// </summary>
    
    public class UserDto : DtoBase {
        /// <summary>
        /// 组织机构编号(OrganizationsId)
        /// </summary>
        [Display( Name = "组织机构编号(OrganizationsId)" )]
        [DataMember]
        public Guid? OrganizationsId { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display( Name = "商户编号" )]
        [DataMember]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 用户名称（UserName）
        /// </summary>
        [Required(ErrorMessage = "用户名称（UserName）不能为空")]
        [StringLength( 100, ErrorMessage = "用户名称（UserName）输入过长，不能超过100位" )]
        [Display( Name = "用户名称（UserName）" )]
        [DataMember]
        public string Account { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [StringLength( 100, ErrorMessage = "昵称输入过长，不能超过100位" )]
        [Display( Name = "昵称" )]
        [DataMember]
        public string Nickname { get; set; }
        /// <summary>
        /// 密码（Password）
        /// </summary>
        [StringLength( 100, ErrorMessage = "密码（Password）输入过长，不能超过100位" )]
        [Display( Name = "密码（Password）" )]
        [DataMember]
        public string Password { get; set; }
        /// <summary>
        /// 头像（Head）
        /// </summary>
        [StringLength( 200, ErrorMessage = "头像（Head）输入过长，不能超过200位" )]
        [Display( Name = "头像（Head）" )]
        [DataMember]
        public string Head { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        [StringLength( 20, ErrorMessage = "手机号输入过长，不能超过20位" )]
        [Display( Name = "手机号" )]
        [DataMember]
        public string Mobile { get; set; }
        /// <summary>
        /// 注册日期（RegisterTime）
        /// </summary>
        [Required(ErrorMessage = "注册日期（RegisterTime）不能为空")]
        [Display( Name = "注册日期（RegisterTime）" )]
        [DataMember]
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display( Name = "类型" )]
        [DataMember]
        public int Type { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态不能为空")]
        [Display( Name = "状态" )]
        [DataMember]
        public int State { get; set; }
        /// <summary>
        /// 盐值
        /// </summary>
        [StringLength( 10, ErrorMessage = "盐值输入过长，不能超过10位" )]
        [Display( Name = "盐值" )]
        [DataMember]
        public string Saltd { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        [StringLength( 18, ErrorMessage = "用户编号输入过长，不能超过18位" )]
        [Display( Name = "用户编号" )]
        [DataMember]
        public string IdCard { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [StringLength( 20, ErrorMessage = "真实姓名输入过长，不能超过20位" )]
        [Display( Name = "真实姓名" )]
        [DataMember]
        public string RealName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required(ErrorMessage = "性别不能为空")]
        [Display( Name = "性别" )]
        [DataMember]
        public int Sex { get; set; }
        /// <summary>
        /// 推荐人
        /// </summary>
        [Display( Name = "推荐人" )]
        [DataMember]
        public Guid? Referrer { get; set; }
        /// <summary>
        /// 锁定
        /// </summary>
        [Required(ErrorMessage = "锁定不能为空")]
        [Display( Name = "锁定" )]
        [DataMember]
        public bool IsLocked { get; set; }
        /// <summary>
        /// 锁定起始时间
        /// </summary>
        [Display( Name = "锁定起始时间" )]
        [DataMember]
        public DateTime? LockBeginTime { get; set; }
        /// <summary>
        /// 锁定持续时间
        /// </summary>
        [Display( Name = "锁定持续时间" )]
        [DataMember]
        public int? LockDuration { get; set; }
        /// <summary>
        /// 锁定提示消息
        /// </summary>
        [StringLength( 100, ErrorMessage = "锁定提示消息输入过长，不能超过100位" )]
        [Display( Name = "锁定提示消息" )]
        [DataMember]
        public string LockMessage { get; set; }
        /// <summary>
        /// 上次登陆时间
        /// </summary>
        [Display( Name = "上次登陆时间" )]
        [DataMember]
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 上次登陆Ip
        /// </summary>
        [StringLength( 30, ErrorMessage = "上次登陆Ip输入过长，不能超过30位" )]
        [Display( Name = "上次登陆Ip" )]
        [DataMember]
        public string LastLoginIp { get; set; }
        /// <summary>
        /// 本次登陆时间
        /// </summary>
        [Display( Name = "本次登陆时间" )]
        [DataMember]
        public DateTime? CurrentLoginTime { get; set; }
        /// <summary>
        /// 本次登陆Ip
        /// </summary>
        [StringLength( 30, ErrorMessage = "本次登陆Ip输入过长，不能超过30位" )]
        [Display( Name = "本次登陆Ip" )]
        [DataMember]
        public string CurrentLoginIp { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        [DataMember]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        [DataMember]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}