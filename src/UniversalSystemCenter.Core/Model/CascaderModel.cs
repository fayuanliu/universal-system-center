using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Model
{
    /// <summary>
    /// 级联选择模型
    /// </summary>
    public class OptionsModel
    {
        public OptionsModel()
        {
            children = new List<OptionsModel>();
        }
        /// <summary>
        /// 值
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string label { get; set; }

        public bool? isLeaf { get; set; }

        /// <summary>
        ///禁止选择
        /// </summary>
        public bool? disabled { get; set; }

        /// <summary>
        /// 子级
        /// </summary>
        public List<OptionsModel> children { get; set; }
    }

    public class CascaderModel
    {
        /// <summary>
        /// 绑定树形数据
        /// </summary>
        public List<OptionsModel> OptionsList { get; set; }

        /// <summary>
        /// 绑定默认值
        /// </summary>
        public List<OptionsModel> DefaultList { get; set; }

        /// <summary>
        /// 子路径
        /// </summary>
        public List<string> DefaultStr { get; set; }
    }
}
