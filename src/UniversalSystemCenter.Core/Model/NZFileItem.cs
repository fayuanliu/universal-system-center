using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace UniversalSystemCenter.Core.Model
{
    public class NZFileItem
    {
        /// <summary>
        /// 图片标识Id
        /// </summary>
        [DataMember]
        public string Uid { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 图片状态
        /// </summary>
        [DataMember]
        public string Status { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [DataMember]
        public string Url { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// 图片高度
        /// </summary>
        public int Height { get; set; }
    }
}
