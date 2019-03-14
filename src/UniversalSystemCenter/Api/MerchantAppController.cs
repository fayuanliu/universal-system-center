using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 商户应用控制器
    /// </summary>
    public class MerchantAppController : CrudControllerBase<MerchantAppDto, MerchantAppQuery> {
        /// <summary>
        /// 初始化商户应用控制器
        /// </summary>
        /// <param name="service">商户应用服务</param>
        public MerchantAppController( IMerchantAppService service ) : base( service ) {
            MerchantAppService = service;
        }

        /// <summary>
        /// 商户应用服务
        /// </summary>
        public IMerchantAppService MerchantAppService { get; }
    }
}