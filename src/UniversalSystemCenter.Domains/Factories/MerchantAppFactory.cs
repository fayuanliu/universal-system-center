using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 商户应用工厂
    /// </summary>
    public static class MerchantAppFactory {
        /// <summary>
        /// 创建商户应用
        /// </summary>
        /// <param name="merchantAppId">商户应用编号</param>
        /// <param name="merchantId">商户编号</param>
        /// <param name="appId">应用程序编号（AppId）</param>
        /// <param name="expiryTime">到期时间</param>
        /// <param name="registerDate">注册时间</param>
        /// <param name="code">授权码</param>
        /// <param name="state">状态</param>
        /// <param name="version">版本号</param>
        public static MerchantApp Create( 
            Guid merchantAppId,
            Guid? merchantId,
            Guid? appId,
            DateTime expiryTime,
            DateTime registerDate,
            string code,
            int state,
            Byte[] version
        ) {
            MerchantApp result;
            result = new MerchantApp( merchantAppId );
            result.MerchantId = merchantId;
            result.AppId = appId;
            result.ExpiryTime = expiryTime;
            result.RegisterDate = registerDate;
            result.Code = code;
            result.State = state;
            result.Version = version;
            return result;
        }
    }
}