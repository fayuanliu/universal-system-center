using Util.Webs.Controllers;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Apis {
    /// <summary>
    /// 用户控制器
    /// </summary>
    public class UserController : CrudControllerBase<UserDto, UserQuery> {
        /// <summary>
        /// 初始化用户控制器
        /// </summary>
        /// <param name="service">用户服务</param>
        public UserController( IUserService service ) : base( service ) {
            UserService = service;
        }

        /// <summary>
        /// 用户服务
        /// </summary>
        public IUserService UserService { get; }
    }
}