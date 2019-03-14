using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 商户应用消息设置控制器
    /// </summary>
    public class MerchanAppMessageSetController : CrudControllerBase<MerchanAppMessageSetDto, MerchanAppMessageSetQuery> {
        /// <summary>
        /// 初始化商户应用消息设置控制器
        /// </summary>
        /// <param name="service">商户应用消息设置服务</param>
        public MerchanAppMessageSetController( IMerchanAppMessageSetService service ) : base( service ) {
            MerchanAppMessageSetService = service;
        }

        /// <summary>
        /// 商户应用消息设置服务
        /// </summary>
        public IMerchanAppMessageSetService MerchanAppMessageSetService { get; }
    }
}