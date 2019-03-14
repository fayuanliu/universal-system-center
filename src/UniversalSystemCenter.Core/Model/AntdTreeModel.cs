using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Model
{
    /// <summary>
    /// 树形模型
    /// </summary>
    public class AntdTreeModel
    {
        public AntdTreeModel()
        {
            children = new List<AntdTreeModel>();
        }
        public int id { get; set; }

        public string name { get; set; }

        public bool @checked { get; set; }

        public bool disableCheckbox { get; set; }

        public bool halfChecked { get; set; }

        public bool hasChildren { get; set; }


        public List<AntdTreeModel> children { get; set; }


    }
}
