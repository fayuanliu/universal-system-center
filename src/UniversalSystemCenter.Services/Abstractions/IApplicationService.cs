using Util.Applications;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversalSystemCenter.Services.Dtos;
using System;
using UniversalSystemCenter.Core.Result;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 应用程序服务
    /// </summary>
    public interface IApplicationService : ICrudService<ApplicationDto, ApplicationQuery>
    {
        /// <summary>
        /// 根据用户编号，初始化应用
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="userId"></param>
        /// <param name="roleIdList"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<Result> ApplicationInitAsync(Guid appId, Guid userId, List<Guid> roleIdList, string userName);
    }
}