using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 岗位服务
    /// </summary>
    public interface IPositionService : ICrudService<PositionDto, PositionQuery> {
    }
}