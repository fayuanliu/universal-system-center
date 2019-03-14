using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace UniversalSystemCenter.Core.Model
{
    public class CheckedBox
    {
        /// <summary>
        /// 值
        /// </summary>
        [DataMember]
        public string value { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [DataMember]
        public string label { get; set; }

        [DataMember]
        public bool @checked { get; set; }
    }
}
