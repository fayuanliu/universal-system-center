using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace UniversalSystemCenter.Cores.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class WebClientHelp: WebClient
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public WebClientHelp():this(new CookieContainer())
        { }

        /// <summary>
        /// 带参初始化
        /// </summary>
        /// <param name="cookies"></param>
        public WebClientHelp(CookieContainer cookies)
        {
            if (null == cookies)
            {
                this.CookieContainer = new CookieContainer();
            }
            else
            {
                this.CookieContainer = cookies;
            }
        }

        /// <summary>
        /// Cookie容器
        /// </summary>
        public CookieContainer CookieContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);

            if (request is HttpWebRequest)
            {
                var httpWebRequest = (HttpWebRequest)request;
                httpWebRequest.CookieContainer = this.CookieContainer;
                httpWebRequest.ServicePoint.Expect100Continue = false;
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
                httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                httpWebRequest.Headers.Add(HttpRequestHeader.AcceptLanguage, "zh-CN,zh;q=0.8,en;q=0.6,nl;q=0.4,zh-TW;q=0.2");
                httpWebRequest.KeepAlive = true;
                httpWebRequest.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                if (HttpMethod.Post.ToString() == httpWebRequest.Method)
                {
                    httpWebRequest.ContentType = "application/x-www-form-urlencoded;";
                }

                httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                return httpWebRequest;
            }

            return base.GetWebRequest(address);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected override WebResponse GetWebResponse(WebRequest request)
        {
            WebResponse response = base.GetWebResponse(request);
            string setCookieHeader = response.Headers[HttpResponseHeader.SetCookie];

            if (null != setCookieHeader)
            {
                try
                {
                    if (null != setCookieHeader)
                    {
                        Cookie cookie = new Cookie();
                        cookie.Domain = request.RequestUri.Host;
                        this.CookieContainer.Add(cookie);
                    }
                }
                catch (Exception ex)
                { }

                return response;
            }

            return response;
        }

    }
}
