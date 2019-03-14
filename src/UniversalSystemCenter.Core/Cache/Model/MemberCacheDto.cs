using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Cache.Model
{
    /// <summary>
    /// 会员表缓存
    /// </summary>
    public class MemberCacheDto
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 团队编号
        /// </summary>
        public string TeamId { get; set; }

        /// <summary>
        /// 教练车编号
        /// </summary>
        public string InstructionalCarId { get; set; }
    }
}
