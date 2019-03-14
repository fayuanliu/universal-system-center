using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Cores.Model
{
    public class NzTreeNode
    {
        public NzTreeNode()
        {
            children = new List<NzTreeNode>();
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// key值
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 层级(最顶层为0,子节点逐层加1)
        /// </summary>
        public int level { get; set; }

        /// <summary>
        /// 是否为叶子节点
        /// </summary>
        public bool isLeaf { get; set; }

        /// <summary>
        /// 是否已展开
        /// </summary>
        public string isExpanded { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool isDisabled { get; set; }

        /// <summary>
        /// 是否禁用 checkBox
        /// </summary>
        public bool isDisableCheckbox { get; set; }

        /// <summary>
        /// 是否可选中
        /// </summary>
        public bool isSelectable { get; set; }

        /// <summary>
        /// 是否选中 checkBox
        /// </summary>
        public bool isChecked { get; set; }

        /// <summary>
        /// 子节点是否全选
        /// </summary>
        public bool isAllChecked { get; set; }

        /// <summary>
        /// 子节点有选中但未全选
        /// </summary>
        public bool isHalfChecked { get; set; }

        /// <summary>
        /// 是否已选中
        /// </summary>
        public bool isSelected { get; set; }


        public List<NzTreeNode> children { get; set; }
    }

    /// <summary>
    /// 树形结构返回类型
    /// </summary>
    public class NzTreeNodeResult
    {
        public NzTreeNodeResult()
        {
            NzTreeNodes = new List<NzTreeNode>();
            defaultCheckedKeys = new List<string>();
            defaultSelectedKeys = new List<string>();
            defaultExpandedKeys = new List<string>();
        }
        /// <summary>
        /// 指定选中复选框的节点 
        /// </summary>
        public List<string> defaultCheckedKeys { get; set; }

        /// <summary>
        /// 指定选中的节点 
        /// </summary>
        public List<string> defaultSelectedKeys { get; set; }

        /// <summary>
        /// 展开指定的节点 
        /// </summary>
        public List<string> defaultExpandedKeys { get; set; }

        /// <summary>
        /// 节点
        /// </summary>
        public List<NzTreeNode> NzTreeNodes { get; set; }
    }
}
