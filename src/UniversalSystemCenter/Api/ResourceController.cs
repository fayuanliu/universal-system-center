using UniversalSystemCenter.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 资源控制器
    /// </summary>
    public class ResourceController : Controller{
        /// <summary>
        /// 初始化资源控制器
        /// </summary>
        /// <param name="service">资源服务</param>
        public ResourceController( IResourceService service ) {
            ResourceService = service;
        }

        /// <summary>
        /// 资源服务
        /// </summary>
        public IResourceService ResourceService { get; }
    }
}