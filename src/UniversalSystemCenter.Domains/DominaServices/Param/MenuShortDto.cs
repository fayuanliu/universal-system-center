using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Util.Applications.Dtos;

namespace UniversalSystemCenter.Domains.DominaServices.Param
{
    public class MenuShortDto : DtoBase
    {
        public MenuShortDto()
        {
            Children = new List<MenuShortDto>();
        }
        /// <summary>
        /// 名称
        /// </summary>
        [DataMember]
        [JsonProperty("text")]
        public string Name { get; set; }

        /// <summary>
        /// 是否是菜单组
        /// </summary>
        [DataMember]
        [JsonProperty("group")]
        public bool Group { get; set; }

        /// <summary>
        /// 链接、路由
        /// </summary>
        [DataMember]
        [JsonProperty("link")]
        public string Link { get; set; }


        /// <summary>
        /// 图标
        /// </summary>
        [DataMember]
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 徽章
        /// </summary>
        [DataMember]
        [JsonProperty("badge")]
        public string Badge { get; set; }

        /// <summary>
        /// 子菜单
        /// </summary>
        [DataMember]
        [JsonProperty("children")]
        public List<MenuShortDto> Children { get; set; }
    }
}
