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
    /// 商户服务
    /// </summary>
    public class MerchantService : CrudServiceBase<Merchant, MerchantDto, MerchantQuery>, IMerchantService {
        /// <summary>
        /// 初始化商户服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="merchantRepository">商户仓储</param>
        public MerchantService( IUniversalSysCenterUnitOfWork unitOfWork, IMerchantRepository merchantRepository )
            : base( unitOfWork, merchantRepository ) {
            MerchantRepository = merchantRepository;
        }
        
        /// <summary>
        /// 商户仓储
        /// </summary>
        public IMerchantRepository MerchantRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Merchant> CreateQuery( MerchantQuery param ) {
            return new Query<Merchant>( param );
        }
    }
}