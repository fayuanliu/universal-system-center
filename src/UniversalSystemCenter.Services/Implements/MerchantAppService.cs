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
    /// 商户应用服务
    /// </summary>
    public class MerchantAppService : CrudServiceBase<MerchantApp, MerchantAppDto, MerchantAppQuery>, IMerchantAppService {
        /// <summary>
        /// 初始化商户应用服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="merchantAppRepository">商户应用仓储</param>
        public MerchantAppService( IUniversalSysCenterUnitOfWork unitOfWork, IMerchantAppRepository merchantAppRepository )
            : base( unitOfWork, merchantAppRepository ) {
            MerchantAppRepository = merchantAppRepository;
        }
        
        /// <summary>
        /// 商户应用仓储
        /// </summary>
        public IMerchantAppRepository MerchantAppRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<MerchantApp> CreateQuery( MerchantAppQuery param ) {
            return new Query<MerchantApp>( param );
        }
    }
}