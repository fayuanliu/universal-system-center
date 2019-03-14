using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UniversalSystemCenter.Core.Utils
{
    public interface IVierificationCodeServices
    {
        /// <summary>  
        /// 该方法是将生成的随机数写入图像文件  
        /// </summary>  
        /// <param name="code">code是一个随机数</param>
        /// <param name="numbers">生成位数（默认4位）</param>  
        MemoryStream Create(out string code, int numbers = 4);
    }
}
