using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 用户岗位控制器
    /// </summary>
    public class UserPositionController : CrudControllerBase<UserPositionDto, UserPositionQuery> {
        /// <summary>
        /// 初始化用户岗位控制器
        /// </summary>
        /// <param name="service">用户岗位服务</param>
        public UserPositionController( IUserPositionService service ) : base( service ) {
            UserPositionService = service;
        }

        /// <summary>
        /// 用户岗位服务
        /// </summary>
        public IUserPositionService UserPositionService { get; }
    }
}