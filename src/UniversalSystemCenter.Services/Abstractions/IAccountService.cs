using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 账户服务
    /// </summary>
    public interface IAccountService : ICrudService<AccountDto, AccountQuery> {
    }
}