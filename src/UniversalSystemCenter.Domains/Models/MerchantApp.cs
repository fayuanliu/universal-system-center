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
    /// 商户应用
    /// </summary>
    [DisplayName( "商户应用" )]
    public partial class MerchantApp : AggregateRoot<MerchantApp> {
        /// <summary>
        /// 初始化商户应用
        /// </summary>
        public MerchantApp() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化商户应用
        /// </summary>
        /// <param name="id">商户应用标识</param>
        public MerchantApp( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [DisplayName( "商户编号" )]
        public Guid? MerchantId { get; set; }
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [DisplayName( "应用程序编号（AppId）" )]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 到期时间
        /// </summary>
        [DisplayName( "到期时间" )]
        [Required(ErrorMessage = "到期时间不能为空")]
        public DateTime ExpiryTime { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [DisplayName( "注册时间" )]
        [Required(ErrorMessage = "注册时间不能为空")]
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// 授权码
        /// </summary>
        [DisplayName( "授权码" )]
        [Required(ErrorMessage = "授权码不能为空")]
        [StringLength( 1000, ErrorMessage = "授权码输入过长，不能超过1000位" )]
        public string Code { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName( "状态" )]
        [Required(ErrorMessage = "状态不能为空")]
        public int State { get; set; }
        /// <summary>
        /// 应用程序
        /// </summary>
        [ForeignKey( "AppId" )]
        public Application Application { get; set; }
        /// <summary>
        /// 商户
        /// </summary>
        [ForeignKey( "MerchantId" )]
        public Merchant Merchant { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.MerchantId );
            AddDescription( t => t.AppId );
            AddDescription( t => t.ExpiryTime );
            AddDescription( t => t.RegisterDate );
            AddDescription( t => t.Code );
            AddDescription( t => t.State );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( MerchantApp other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.MerchantId, other.MerchantId );
            AddChange( t => t.AppId, other.AppId );
            AddChange( t => t.ExpiryTime, other.ExpiryTime );
            AddChange( t => t.RegisterDate, other.RegisterDate );
            AddChange( t => t.Code, other.Code );
            AddChange( t => t.State, other.State );
        }
    }
}