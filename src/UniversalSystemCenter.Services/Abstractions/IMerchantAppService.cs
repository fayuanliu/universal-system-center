using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 商户应用服务
    /// </summary>
    public interface IMerchantAppService : ICrudService<MerchantAppDto, MerchantAppQuery> {
    }
}