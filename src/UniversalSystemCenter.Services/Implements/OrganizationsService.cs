using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications.Trees;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Service.Implements {
    /// <summary>
    /// 组织机构服务
    /// </summary>
    public class OrganizationsService : TreeServiceBase<Organizations, OrganizationsDto, OrganizationsQuery>, IOrganizationsService {
        /// <summary>
        /// 初始化组织机构服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="organizationsRepository">组织机构仓储</param>
        public OrganizationsService( IUniversalSysCenterUnitOfWork unitOfWork, IOrganizationsRepository organizationsRepository )
            : base( unitOfWork, organizationsRepository ) {
            OrganizationsRepository = organizationsRepository;
        }
        
        /// <summary>
        /// 组织机构仓储
        /// </summary>
        public IOrganizationsRepository OrganizationsRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Organizations> CreateQuery( OrganizationsQuery param ) {
            return new Query<Organizations>( param );
        }
    }
}