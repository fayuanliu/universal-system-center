using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalSystemCenter.Auth.Config
{
    public static class IdentityConfig
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource("System_Api", "系统管理中心"),
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResourceResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(), //必须要添加，否则报无效的scope错误
                new IdentityResources.Profile()
            };
        }

        /// <summary>
        /// 本地
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                //中央系统管理
                new Client
                {
                    ClientId = "system_center",
                    AllowAccessTokensViaBrowser=true,
                    ClientSecrets = new [] { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes = new [] { IdentityServerConstants.StandardScopes.OfflineAccess, "System_Api" },
                    AllowOfflineAccess = true,
                    AccessTokenLifetime = 36000,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                    RefreshTokenUsage = TokenUsage.ReUse,
                    UpdateAccessTokenClaimsOnRefresh = false,
                    AllowedCorsOrigins=new []{
                        "http://localhost:4203",
                    }
                }               
            };
        }
    }
}
