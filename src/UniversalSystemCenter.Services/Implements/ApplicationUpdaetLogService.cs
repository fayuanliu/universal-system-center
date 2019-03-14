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
    /// 应用更新日志服务
    /// </summary>
    public class ApplicationUpdaetLogService : CrudServiceBase<ApplicationUpdaetLog, ApplicationUpdaetLogDto, ApplicationUpdaetLogQuery>, IApplicationUpdaetLogService {
        /// <summary>
        /// 初始化应用更新日志服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="applicationUpdaetLogRepository">应用更新日志仓储</param>
        public ApplicationUpdaetLogService( IUniversalSysCenterUnitOfWork unitOfWork, IApplicationUpdaetLogRepository applicationUpdaetLogRepository )
            : base( unitOfWork, applicationUpdaetLogRepository ) {
            ApplicationUpdaetLogRepository = applicationUpdaetLogRepository;
        }
        
        /// <summary>
        /// 应用更新日志仓储
        /// </summary>
        public IApplicationUpdaetLogRepository ApplicationUpdaetLogRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<ApplicationUpdaetLog> CreateQuery( ApplicationUpdaetLogQuery param ) {
            return new Query<ApplicationUpdaetLog>( param );
        }
    }
}