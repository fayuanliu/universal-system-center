using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 商户服务
    /// </summary>
    public interface IMerchantService : ICrudService<MerchantDto, MerchantQuery> {
    }
}