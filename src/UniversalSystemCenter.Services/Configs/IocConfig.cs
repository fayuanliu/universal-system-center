using Autofac;
using Util.Dependency;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Data.UnitOfWorks.MySql;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Data.Repositories;
using UniversalSystemCenter.Service.Abstractions;
using UniversalSystemCenter.Service.Implements;
using UniversalSystemCenter.Core.Auth;
using UniversalSystemCenter.Core.Configuration.Services;
using UniversalSystemCenter.Core.Upload;
using UniversalSystemCenter.Domains.DominaServices.Impl;
using UniversalSystemCenter.Domains.DominaServices.Interface;

namespace UniversalSystemCenter.Service.Configs {
    /// <summary>
    /// 依赖注入配置
    /// </summary>
    public class IocConfig : ConfigBase {
        /// <summary>
        /// 加载配置
        /// </summary>
        protected override void Load( ContainerBuilder builder ) {
            LoadInfrastructure( builder );
            LoadRepositories( builder );
            LoadDomainServices( builder );
            LoadApplicationServices( builder );
        }

        /// <summary>
        /// 加载基础设施
        /// </summary>
        protected virtual void LoadInfrastructure( ContainerBuilder builder ) {
            builder.AddScoped<IUniversalSysCenterUnitOfWork, UniversalSysCenterUnitOfWork>();
            builder.AddScoped<IAuthRequest, AuthRequest>();
            builder.AddScoped<IUploadFile, UploadFile>();
            builder.AddScoped<AuthHostConfigurationServices, AuthHostConfigurationServices>();

        }

        /// <summary>
        /// 加载仓储
        /// </summary>
        protected virtual void LoadRepositories( ContainerBuilder builder ) {
            builder.AddScoped<IApplicationRepository,ApplicationRepository>();
            builder.AddScoped<IApplicationUpdaetLogRepository,ApplicationUpdaetLogRepository>();
            builder.AddScoped<IAreaRepository,AreaRepository>();
            builder.AddScoped<IAttachmentRepository,AttachmentRepository>();
            builder.AddScoped<IMenuRepository,MenuRepository>();
            builder.AddScoped<IMerchanAppMessageSetRepository,MerchanAppMessageSetRepository>();
            builder.AddScoped<IMessageCategoryRepository,MessageCategoryRepository>();
            builder.AddScoped<IMerchantRepository,MerchantRepository>();
            builder.AddScoped<IMerchantAppRepository,MerchantAppRepository>();
            builder.AddScoped<IMessageRepository,MessageRepository>();
            builder.AddScoped<IMessageContentRepository,MessageContentRepository>();
            builder.AddScoped<IMessageTemplateRepository,MessageTemplateRepository>();
            builder.AddScoped<IOrganizationsRepository,OrganizationsRepository>();
            builder.AddScoped<IOrganizationsRegionRepository,OrganizationsRegionRepository>();
            builder.AddScoped<IPermissionRepository,PermissionRepository>();
            builder.AddScoped<IResourceRepository,ResourceRepository>();
            builder.AddScoped<IPositionRepository,PositionRepository>();
            builder.AddScoped<IRoleRepository,RoleRepository>();
            builder.AddScoped<IRoleMenuRepository,RoleMenuRepository>();
            builder.AddScoped<IRolePermissionRepository,RolePermissionRepository>();
            builder.AddScoped<IUserRepository,UserRepository>();
            builder.AddScoped<IAccountRepository, AccountRepository>();
            builder.AddScoped<IUserPermissionRepository,UserPermissionRepository>();
            builder.AddScoped<IUserPositionRepository,UserPositionRepository>();
            builder.AddScoped<IUserRoleRepository,UserRoleRepository>();
        }
        
        /// <summary>
        /// 加载领域服务
        /// </summary>
        protected virtual void LoadDomainServices( ContainerBuilder builder )
        {
            builder.AddScoped<IMenuDomainService, MenuDomainService>().PropertiesAutowired();
            builder.AddScoped<IPermissionDomainService, PermissionDomainService>().PropertiesAutowired();
        }
        
        /// <summary>
        /// 加载应用服务
        /// </summary>
        protected virtual void LoadApplicationServices( ContainerBuilder builder ) {
            builder.AddScoped<IApplicationService,ApplicationService>().PropertiesAutowired();
            builder.AddScoped<IApplicationUpdaetLogService,ApplicationUpdaetLogService>().PropertiesAutowired();
            builder.AddScoped<IAreaService,AreaService>().PropertiesAutowired();
            builder.AddScoped<IAttachmentService,AttachmentService>().PropertiesAutowired();
            builder.AddScoped<IMenuService,MenuService>().PropertiesAutowired();
            builder.AddScoped<IMerchanAppMessageSetService,MerchanAppMessageSetService>().PropertiesAutowired();
            builder.AddScoped<IMessageCategoryService,MessageCategoryService>().PropertiesAutowired();
            builder.AddScoped<IMerchantService,MerchantService>().PropertiesAutowired();
            builder.AddScoped<IMerchantAppService,MerchantAppService>().PropertiesAutowired();
            builder.AddScoped<IMessageService,MessageService>().PropertiesAutowired();
            builder.AddScoped<IMessageContentService,MessageContentService>().PropertiesAutowired();
            builder.AddScoped<IMessageTemplateService,MessageTemplateService>().PropertiesAutowired();
            builder.AddScoped<IOrganizationsService,OrganizationsService>().PropertiesAutowired();
            builder.AddScoped<IOrganizationsRegionService,OrganizationsRegionService>().PropertiesAutowired();
            builder.AddScoped<IPermissionService,PermissionService>().PropertiesAutowired();
            builder.AddScoped<IResourceService,ResourceService>().PropertiesAutowired();
            builder.AddScoped<IPositionService,PositionService>().PropertiesAutowired();
            builder.AddScoped<IRoleService,RoleService>().PropertiesAutowired();
            builder.AddScoped<IRoleMenuService,RoleMenuService>().PropertiesAutowired();
            builder.AddScoped<IRolePermissionService,RolePermissionService>().PropertiesAutowired();
            builder.AddScoped<IUserService,UserService>().PropertiesAutowired();
            builder.AddScoped<IAccountService, AccountService>().PropertiesAutowired();
            builder.AddScoped<IUserPermissionService,UserPermissionService>().PropertiesAutowired();
            builder.AddScoped<IUserPositionService,UserPositionService>().PropertiesAutowired();
            builder.AddScoped<IUserRoleService,UserRoleService>().PropertiesAutowired();
        }
    }
}