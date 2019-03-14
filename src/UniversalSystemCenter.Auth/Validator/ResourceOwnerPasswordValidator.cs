using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using Util;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using UniversalSystemCenter.Core.Auth.Param;
using UniversalSystemCenter.Service.Abstractions;
using Util.Webs.Commons;
using UniversalSystemCenter.Core.Result;

namespace UniversalSystemCenter.Auth
{
    /// <summary>
    /// 验证资源所有的密码
    /// </summary>
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly IUserService _usersServices;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="UserServices"></param>
        public ResourceOwnerPasswordValidator(IUserService UserServices)
        {
            _usersServices = UserServices;
        }

        /// <summary>
        /// 用户密码认证
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {

            LoginDto loginDto = new LoginDto()
            {
                Password = context.Password,
                UserName = context.UserName,
                ClientId = context.Request.Client.ClientId
            };
            var result = await _usersServices.LoginAsync(loginDto);
            if (result.ResultEnum != ResultEnum.Sucess)
            {
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, result.Message);
            }
            else
            {
                var data = result.Data as LoginUser;
                var claim = new Claim[]
                {
                    new Claim(JwtClaimTypes.Id, data.Id),
                    new Claim(JwtClaimTypes.Name, data.UserName??string.Empty),
                    new Claim("RoleIds", data.RoleIdList.Join()),
                    new Claim("OrganizationsId", data.OrganizationsId??string.Empty),
                    new Claim("Head", data.Head??string.Empty),
                    new Claim("RealName", data.RealName??string.Empty),
                };
                Dictionary<string, object> user = new Dictionary<string, object>();
                user.Add("user", data);
                context.Result = new GrantValidationResult(
                 subject: context.UserName,
                 authenticationMethod: "custom",
                 claims: claim,
                 customResponse: user);
            }
        }

    }
}
