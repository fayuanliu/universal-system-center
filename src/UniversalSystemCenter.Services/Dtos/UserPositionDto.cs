using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using Util.Applications.Dtos;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 用户岗位数据传输对象
    /// </summary>
    
    public class UserPositionDto : DtoBase {
        /// <summary>
        /// 用户编号
        /// </summary>
        [Required(ErrorMessage = "用户编号不能为空")]
        [Display( Name = "用户编号" )]
        [DataMember]
        public Guid UserId { get; set; }
        /// <summary>
        /// 岗位编号
        /// </summary>
        [Required(ErrorMessage = "岗位编号不能为空")]
        [Display( Name = "岗位编号" )]
        [DataMember]
        public Guid PostId { get; set; }
    }
}