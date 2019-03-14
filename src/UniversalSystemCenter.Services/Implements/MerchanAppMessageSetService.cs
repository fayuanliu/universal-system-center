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
    /// 商户应用消息设置服务
    /// </summary>
    public class MerchanAppMessageSetService : CrudServiceBase<MerchanAppMessageSet, MerchanAppMessageSetDto, MerchanAppMessageSetQuery>, IMerchanAppMessageSetService {
        /// <summary>
        /// 初始化商户应用消息设置服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="merchanAppMessageSetRepository">商户应用消息设置仓储</param>
        public MerchanAppMessageSetService( IUniversalSysCenterUnitOfWork unitOfWork, IMerchanAppMessageSetRepository merchanAppMessageSetRepository )
            : base( unitOfWork, merchanAppMessageSetRepository ) {
            MerchanAppMessageSetRepository = merchanAppMessageSetRepository;
        }
        
        /// <summary>
        /// 商户应用消息设置仓储
        /// </summary>
        public IMerchanAppMessageSetRepository MerchanAppMessageSetRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<MerchanAppMessageSet> CreateQuery( MerchanAppMessageSetQuery param ) {
            return new Query<MerchanAppMessageSet>( param );
        }
    }
}