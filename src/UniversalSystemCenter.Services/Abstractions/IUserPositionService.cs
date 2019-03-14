using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 用户岗位服务
    /// </summary>
    public interface IUserPositionService : ICrudService<UserPositionDto, UserPositionQuery> {
    }
}