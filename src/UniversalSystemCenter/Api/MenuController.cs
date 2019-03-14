using UniversalSystemCenter.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace UniversalSystemCenter.Apis
{
    /// <summary>
    /// 菜单控制器
    /// </summary>
    public class MenuController : Controller
    {
        /// <summary>
        /// 初始化菜单控制器
        /// </summary>
        /// <param name="service">菜单服务</param>
        public MenuController(IMenuService service)
        {
            MenuService = service;
        }

        /// <summary>
        /// 菜单服务
        /// </summary>
        public IMenuService MenuService { get; }
    }
}