using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Service.Implements {
    /// <summary>
    /// 用户角色服务
    /// </summary>
    public class UserRoleService : CrudServiceBase<UserRole, UserRoleDto, UserRoleQuery>, IUserRoleService {
        /// <summary>
        /// 初始化用户角色服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="userRoleRepository">用户角色仓储</param>
        public UserRoleService( IUniversalSysCenterUnitOfWork unitOfWork, IUserRoleRepository userRoleRepository )
            : base( unitOfWork, userRoleRepository ) {
            UserRoleRepository = userRoleRepository;
        }
        
        /// <summary>
        /// 用户角色仓储
        /// </summary>
        public IUserRoleRepository UserRoleRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<UserRole> CreateQuery( UserRoleQuery param ) {
            return new Query<UserRole>( param );
        }
    }
}