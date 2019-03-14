using UniversalSystemCenter.Core.Auth.Param;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UniversalSystemCenter.Core.Auth
{
    public interface IAuthRequest
    {
        /// <summary>
        /// 发起密码模式授权
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
       Task<Result.Result> SendPasswordAuth(Client client);
    }
}
