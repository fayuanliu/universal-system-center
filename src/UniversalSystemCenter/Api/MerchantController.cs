using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 商户控制器
    /// </summary>
    public class MerchantController : CrudControllerBase<MerchantDto, MerchantQuery> {
        /// <summary>
        /// 初始化商户控制器
        /// </summary>
        /// <param name="service">商户服务</param>
        public MerchantController( IMerchantService service ) : base( service ) {
            MerchantService = service;
        }

        /// <summary>
        /// 商户服务
        /// </summary>
        public IMerchantService MerchantService { get; }
    }
}