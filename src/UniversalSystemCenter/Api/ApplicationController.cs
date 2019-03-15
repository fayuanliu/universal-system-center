using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UniversalSystemCenter.Core.Web;
using System;
using Microsoft.AspNetCore.Authorization;

namespace UniversalSystemCenter.Apis
{
    /// <summary>
    /// 应用程序控制器
    /// </summary>
    [Authorize]
    public class ApplicationController : BaseController
    {
        /// <summary>
        /// 初始化应用程序控制器
        /// </summary>
        /// <param name="service">应用程序服务</param>
        public ApplicationController(IApplicationService service)
        {
            ApplicationService = service;
        }

        /// <summary>
        /// 应用程序服务
        /// </summary>
        public IApplicationService ApplicationService { get; }

        /// <summary>
        /// 初始化应用
        /// </summary>
        /// <returns></returns>
        [HttpGet("InitApp")]
        public async Task<JsonResult> InitApp(Guid appId)
        {
            var data = await ApplicationService.ApplicationInitAsync(appId, UserId, RoleIdList, UserName);
            return Json(data);
        }
    }
}