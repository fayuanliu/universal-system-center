using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Util;

namespace UniversalSystemCenter.Core.Utils
{
    public static class EncryptExtension
    {
        /// <summary>
        /// Md5加密加入盐值，返回32位结果
        /// </summary>
        /// <param name="value">值</param>
        public static string Md5WithSaltBy32(string value,string salt)
        {
            return Md5By32(value + salt, Encoding.UTF8);
        }
        /// <summary>
        /// Md5加密，返回32位结果
        /// </summary>
        /// <param name="value">值</param>
        /// <param name="encoding">字符编码</param>
        public static string Md5By32(string value, Encoding encoding)
        {
            return Md5(value, encoding, null, null);
        }
        /// <summary>
        /// Md5加密
        /// </summary>
        private static string Md5(string value, Encoding encoding, int? startIndex, int? length)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;
            var md5 = new MD5CryptoServiceProvider();
            string result;
            try
            {
                var hash = md5.ComputeHash(encoding.GetBytes(value));
                result = startIndex == null ? BitConverter.ToString(hash) : BitConverter.ToString(hash, startIndex.SafeValue(), length.SafeValue());
            }
            finally
            {
                md5.Clear();
            }
            return result.Replace("-", "");
        }
        
    }
}
