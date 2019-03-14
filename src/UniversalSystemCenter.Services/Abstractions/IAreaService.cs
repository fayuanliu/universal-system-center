using Util.Applications.Trees;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 地区服务
    /// </summary>
    public interface IAreaService : ITreeService<AreaDto, AreaQuery> {
    }
}