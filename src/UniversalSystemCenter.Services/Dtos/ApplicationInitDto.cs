using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using UniversalSystemCenter.Domains.DominaServices.Param;
using UniversalSystemCenter.Service.Dtos;

namespace UniversalSystemCenter.Services.Dtos
{
    /// <summary>
    /// 应用初始数据模型
    /// </summary>
    public class ApplicationInitDto
    {
        /// <summary>
        /// 应用程序
        /// </summary>
        [DataMember]
        public ApplicationDto App { get; set; }

        /// <summary>
        /// 当前登录用户
        /// </summary>
        [DataMember]
        public UserDto User { get; set; }

        /// <summary>
        /// 菜单
        /// </summary>
        [DataMember]
        public List<MenuShortDto> Menu { get; set; }

        /// <summary>
        /// 权限点
        /// </summary>
        public List<string> Ability { get; set; }

        /// <summary>
        /// 是否不限制权限
        /// </summary>
        public bool IsAcl { get; set; } = false;
    }
}
