using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 岗位控制器
    /// </summary>
    public class PositionController : CrudControllerBase<PositionDto, PositionQuery> {
        /// <summary>
        /// 初始化岗位控制器
        /// </summary>
        /// <param name="service">岗位服务</param>
        public PositionController( IPositionService service ) : base( service ) {
            PositionService = service;
        }

        /// <summary>
        /// 岗位服务
        /// </summary>
        public IPositionService PositionService { get; }
    }
}