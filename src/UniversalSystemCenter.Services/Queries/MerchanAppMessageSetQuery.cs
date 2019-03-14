using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 商户应用消息设置查询参数
    /// </summary>
    public class MerchanAppMessageSetQuery : QueryParameter {
        /// <summary>
        /// 消息设置编号
        /// </summary>
        [Display(Name="消息设置编号")]
        public Guid? SetId { get; set; }
        /// <summary>
        /// 消息分类编号（MessageCategoryId）
        /// </summary>
        [Display(Name="消息分类编号（MessageCategoryId）")]
        public Guid? CategoryId { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [Display(Name="消息类型")]
        public int? Type { get; set; }
        /// <summary>
        /// 状态（State）
        /// </summary>
        [Display(Name="状态（State）")]
        public int? State { get; set; }
        /// <summary>
        /// 会员（MemberId）
        /// </summary>
        [Display(Name="会员（MemberId）")]
        public Guid? MerchanId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name="是否删除")]
        public byte? IsDeleted { get; set; }
    }
}