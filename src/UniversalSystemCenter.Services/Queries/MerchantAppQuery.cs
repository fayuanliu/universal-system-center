using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 商户应用查询参数
    /// </summary>
    public class MerchantAppQuery : QueryParameter {
        /// <summary>
        /// 商户应用编号
        /// </summary>
        [Display(Name="商户应用编号")]
        public Guid? MerchantAppId { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        [Display(Name="商户编号")]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [Display(Name="应用程序编号（AppId）")]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 起始到期时间
        /// </summary>
        [Display( Name = "起始到期时间" )]
        public DateTime? BeginExpiryTime { get; set; }
        /// <summary>
        /// 结束到期时间
        /// </summary>
        [Display( Name = "结束到期时间" )]
        public DateTime? EndExpiryTime { get; set; }
        /// <summary>
        /// 起始注册时间
        /// </summary>
        [Display( Name = "起始注册时间" )]
        public DateTime? BeginRegisterDate { get; set; }
        /// <summary>
        /// 结束注册时间
        /// </summary>
        [Display( Name = "结束注册时间" )]
        public DateTime? EndRegisterDate { get; set; }
        
        private string _code = string.Empty;
        /// <summary>
        /// 授权码
        /// </summary>
        [Display(Name="授权码")]
        public string Code {
            get => _code == null ? string.Empty : _code.Trim();
            set => _code = value;
        }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? State { get; set; }
    }
}