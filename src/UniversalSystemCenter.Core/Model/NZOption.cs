using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Model
{
    public class NZOption
    {
        /// <summary>
        /// 显示展示的option内容
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// option的value值，与nz-select选择option后的ngModel属性对应
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool disabled { get; set; }

        
    }
}
