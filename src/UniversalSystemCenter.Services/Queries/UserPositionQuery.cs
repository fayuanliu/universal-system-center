using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 用户岗位查询参数
    /// </summary>
    public class UserPositionQuery : QueryParameter {
        /// <summary>
        /// 用户岗位编号
        /// </summary>
        [Display(Name="用户岗位编号")]
        public Guid? UserPositionId { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        [Display(Name="用户编号")]
        public Guid? UserId { get; set; }
        /// <summary>
        /// 岗位编号
        /// </summary>
        [Display(Name="岗位编号")]
        public Guid? PostId { get; set; }
    }
}