using Microsoft.AspNetCore.Mvc;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 地区控制器
    /// </summary>
    public class AreaController : Controller {
        /// <summary>
        /// 初始化地区控制器
        /// </summary>
        /// <param name="service">地区服务</param>
        public AreaController( IAreaService service ){
            AreaService = service;
        }

        /// <summary>
        /// 地区服务
        /// </summary>
        public IAreaService AreaService { get; }
    }
}