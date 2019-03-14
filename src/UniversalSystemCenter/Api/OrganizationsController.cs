using UniversalSystemCenter.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 组织机构控制器
    /// </summary>
    public class OrganizationsController : Controller
    {
        /// <summary>
        /// 初始化组织机构控制器
        /// </summary>
        /// <param name="service">组织机构服务</param>
        public OrganizationsController( IOrganizationsService service ) {
            OrganizationsService = service;
        }

        /// <summary>
        /// 组织机构服务
        /// </summary>
        public IOrganizationsService OrganizationsService { get; }
    }
}