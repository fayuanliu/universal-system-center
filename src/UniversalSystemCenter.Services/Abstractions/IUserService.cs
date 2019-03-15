using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using System.Threading.Tasks;
using UniversalSystemCenter.Core.Auth.Param;
using UniversalSystemCenter.Core.Result;

namespace UniversalSystemCenter.Service.Abstractions
{
    /// <summary>
    /// 用户服务
    /// </summary>
    public interface IUserService : ICrudService<UserDto, UserQuery>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginDto"></param>
        /// <returns></returns>
        Task<Result> LoginAsync(LoginDto loginDto);

        /// <summary>
        /// 系统中心用户登录
        /// </summary>
        /// <param name="loginDto"></param>
        /// <returns></returns>
        Task<Result> UserLoginAsync(LoginDto loginDto);
    }
}