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
using System.Threading.Tasks;
using UniversalSystemCenter.Services.Dtos;
using System.Collections.Generic;
using UniversalSystemCenter.Domains.DominaServices.Interface;
using System;

namespace UniversalSystemCenter.Service.Implements
{
    /// <summary>
    /// 应用程序服务
    /// </summary>
    public class ApplicationService : CrudServiceBase<Application, ApplicationDto, ApplicationQuery>, IApplicationService
    {
        /// <summary>
        /// 初始化应用程序服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="applicationRepository">应用程序仓储</param>
        public ApplicationService(
            IUniversalSysCenterUnitOfWork unitOfWork,
            IApplicationRepository applicationRepository,
             IUserRepository userRepository,
              IMenuDomainService menuDomainService,
              IPermissionDomainService permissionDomainService
            )
            : base(unitOfWork, applicationRepository)
        {
            ApplicationRepository = applicationRepository;
            _userRepository = userRepository;
            _menuDomainService = menuDomainService;
            _permissionDomainService = permissionDomainService;
        }

        /// <summary>
        /// 应用程序仓储
        /// </summary>
        public IApplicationRepository ApplicationRepository { get; set; }

        private IUserRepository _userRepository { get; set; }

        private IMenuDomainService _menuDomainService;
        private IPermissionDomainService _permissionDomainService;

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Application> CreateQuery(ApplicationQuery param)
        {
            return new Query<Application>(param);
        }

        /// <summary>
        /// 根据用户编号，初始化应用
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="userId"></param>
        /// <param name="roleIdList"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<ApplicationInitDto> ApplicationInitAsync(Guid appId, Guid userId, List<Guid> roleIdList, string userName)
        {
            ApplicationInitDto applicationInitDto = new ApplicationInitDto();
            var userData = await _userRepository.SingleAsync(a => a.Id == userId);
            var appData = await ApplicationRepository.SingleAsync(a => a.Id == appId);
            ApplicationDto appDto = new ApplicationDto()
            {
                Note = appData.Note,
                Id = appData.Id.ToString(),
                Name = appData.Name,
            };
            applicationInitDto.App = appDto;
            if (null != userData)
            {
                applicationInitDto.User = userData.MapTo<UserDto>();
                if (userName == "admin")
                {
                    applicationInitDto.Menu = _menuDomainService.LoadTree(appId);
                    applicationInitDto.IsAcl = true;
                }
                else
                {
                    applicationInitDto.Menu = _menuDomainService.GetRoleMenus(roleIdList, appId);
                }
                if (null != roleIdList)
                {
                    applicationInitDto.Ability = _permissionDomainService.GetAbilityByRoleIds(roleIdList);
                }
            }
            return applicationInitDto;
        }
    }
}