using UniversalSystemCenter.Core.Auth.Param;
using UniversalSystemCenter.Core.Configuration.Services;
using UniversalSystemCenter.Core.Result;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Util.Webs.Clients;
using System;

namespace UniversalSystemCenter.Core.Auth
{
    public class AuthRequest: IAuthRequest
    {
      private readonly  AuthHostConfigurationServices _authHostConfigurationServices;
        public AuthRequest(AuthHostConfigurationServices authHostConfigurationServices)
        {
            _authHostConfigurationServices = authHostConfigurationServices;
        }
        public async Task<Result.Result> SendPasswordAuth(Client client)
        {
            Result.Result result = new Result.Result();
            try
            {
                //发起授权请求
                HttpRequest request = new HttpRequest(HttpMethod.Post, _authHostConfigurationServices.AuthHostConfigurations.Authority + "connect/token");
                IDictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("client_id", client.ClientId);
                parameters.Add("client_secret", client.Client_Secret);
                parameters.Add("grant_type", client.Grant_Type);
                parameters.Add("username", client.UserName);
                parameters.Add("password", client.Password);
                request.Data(parameters);
                request.ContentType(HttpContentType.FormUrlEncoded);
                var data = await request.ResultAsync();
                var resultData = Util.Helpers.Json.ToObject<AuthResut>(data);
                if (!string.IsNullOrEmpty(resultData.refresh_token))
                {
                    result.Message = string.Empty;
                    result.ResultEnum = ResultEnum.Sucess;
                    result.Code = 200;
                    result.Data = resultData;
                }
                else
                {
                    result.Message = "授权出错：" + (!string.IsNullOrEmpty(resultData.error_description) ? resultData .error_description: resultData.error);
                    result.ResultEnum = ResultEnum.Error;
                    result.Code = 500;
                }               
            }
            catch (Exception ex)
            {
                result.Message = "授权出错：" + ex.Message;
                result.ResultEnum = ResultEnum.Error;
                result.Code = 500;
            }
            return result;
        }
    }
}
