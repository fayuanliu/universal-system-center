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
        /// 员工编号
        /// </summary>
        [StringLength( 50, ErrorMessage = "员工编号输入过长，不能超过50位" )]
        [Display( Name = "员工编号" )]
        [DataMember]
        public string EId { get; set; }
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
        /// 账户编号
        /// </summary>
        [Display( Name = "账户编号" )]
        [DataMember]
        public Guid? AccountId { get; set; }
        /// <summary>
        /// 注册日期（RegisterTime）
        /// </summary>
        [Required(ErrorMessage = "注册日期（RegisterTime）不能为空")]
        [Display( Name = "注册日期（RegisterTime）" )]
        [DataMember]
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 锁定
        /// </summary>
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