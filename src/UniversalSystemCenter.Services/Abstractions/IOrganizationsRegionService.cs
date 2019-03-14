using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 部门业务区域服务
    /// </summary>
    public interface IOrganizationsRegionService : ICrudService<OrganizationsRegionDto, OrganizationsRegionQuery> {
    }
}