using Util.Applications.Trees;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 资源服务
    /// </summary>
    public interface IResourceService : ITreeService<ResourceDto, ResourceQuery> {
    }
}