using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UniversalSystemCenter.Core.Result
{
    public enum ResultEnum
    {
        [Description("成功")]
        Sucess,
        [Description("错误")]
        Error,
        [Description("提示")]
        Warning,
    }
}
