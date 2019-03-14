using Microsoft.EntityFrameworkCore;
using Util.Datas.UnitOfWorks;

namespace UniversalSystemCenter.Data.UnitOfWorks.PgSql {
    /// <summary>
    /// 工作单元
    /// </summary>
    public class UniversalSysCenterUnitOfWork : Util.Datas.Ef.PgSql.UnitOfWork,IUniversalSysCenterUnitOfWork {
        /// <summary>
        /// 初始化工作单元
        /// </summary>
        /// <param name="options">配置项</param>
        /// <param name="unitOfWorkManager">工作单元服务</param>
        public UniversalSysCenterUnitOfWork( DbContextOptions options, IUnitOfWorkManager unitOfWorkManager ) : base( options, unitOfWorkManager ) {
        }
    }
}