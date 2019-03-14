using Util.Applications.Trees;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 组织机构服务
    /// </summary>
    public interface IOrganizationsService : ITreeService<OrganizationsDto, OrganizationsQuery> {
    }
}