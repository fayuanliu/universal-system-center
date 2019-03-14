using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 应用更新日志控制器
    /// </summary>
    public class ApplicationUpdaetLogController : CrudControllerBase<ApplicationUpdaetLogDto, ApplicationUpdaetLogQuery> {
        /// <summary>
        /// 初始化应用更新日志控制器
        /// </summary>
        /// <param name="service">应用更新日志服务</param>
        public ApplicationUpdaetLogController( IApplicationUpdaetLogService service ) : base( service ) {
            ApplicationUpdaetLogService = service;
        }

        /// <summary>
        /// 应用更新日志服务
        /// </summary>
        public IApplicationUpdaetLogService ApplicationUpdaetLogService { get; }
    }
}