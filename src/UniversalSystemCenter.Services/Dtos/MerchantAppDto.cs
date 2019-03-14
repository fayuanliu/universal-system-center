using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 商户应用数据传输对象
    /// </summary>
    
    public class MerchantAppDto : DtoBase {
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display( Name = "商户编号" )]
        [DataMember]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [Display( Name = "应用程序编号（AppId）" )]
        [DataMember]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 到期时间
        /// </summary>
        [Required(ErrorMessage = "到期时间不能为空")]
        [Display( Name = "到期时间" )]
        [DataMember]
        public DateTime ExpiryTime { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [Required(ErrorMessage = "注册时间不能为空")]
        [Display( Name = "注册时间" )]
        [DataMember]
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// 授权码
        /// </summary>
        [Required(ErrorMessage = "授权码不能为空")]
        [StringLength( 1000, ErrorMessage = "授权码输入过长，不能超过1000位" )]
        [Display( Name = "授权码" )]
        [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态不能为空")]
        [Display( Name = "状态" )]
        [DataMember]
        public int State { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}