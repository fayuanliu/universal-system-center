using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Applications.Trees;

namespace UniversalSystemCenter.Service.Dtos {
    /// <summary>
    /// 菜单数据传输对象
    /// </summary>
    
    public class MenuDto : TreeDtoBase {
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [Display( Name = "应用程序编号（AppId）" )]
        [DataMember]
        public Guid? AppId { get; set; }
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Required(ErrorMessage = "名称（Name）不能为空")]
        [StringLength( 200, ErrorMessage = "名称（Name）输入过长，不能超过200位" )]
        [Display( Name = "名称（Name）" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 是否是菜单组（Group）
        /// </summary>
        [Required(ErrorMessage = "是否是菜单组（Group）不能为空")]
        [Display( Name = "是否是菜单组（Group）" )]
        [DataMember]
        public bool IsGroup { get; set; }
        /// <summary>
        /// 链接、路由（Link）
        /// </summary>
        [StringLength( 500, ErrorMessage = "链接、路由（Link）输入过长，不能超过500位" )]
        [Display( Name = "链接、路由（Link）" )]
        [DataMember]
        public string Link { get; set; }
        /// <summary>
        /// 中文路径
        /// </summary>
        [StringLength( 800, ErrorMessage = "中文路径输入过长，不能超过800位" )]
        [Display( Name = "中文路径" )]
        [DataMember]
        public string PathText { get; set; }
        /// <summary>
        /// 图标（Icon）
        /// </summary>
        [StringLength( 100, ErrorMessage = "图标（Icon）输入过长，不能超过100位" )]
        [Display( Name = "图标（Icon）" )]
        [DataMember]
        public string Icon { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Required(ErrorMessage = "是否末级不能为空")]
        [Display( Name = "是否末级" )]
        [DataMember]
        public bool IsLeave { get; set; }
        /// <summary>
        /// 徽章（Badge）
        /// </summary>
        [StringLength( 20, ErrorMessage = "徽章（Badge）输入过长，不能超过20位" )]
        [Display( Name = "徽章（Badge）" )]
        [DataMember]
        public string Badge { get; set; }
        /// <summary>
        /// 是否隐藏（Hide）
        /// </summary>
        [Required(ErrorMessage = "是否隐藏（Hide）不能为空")]
        [Display( Name = "是否隐藏（Hide）" )]
        [DataMember]
        public bool IsOpen { get; set; }
        /// <summary>
        /// 分类编码
        /// </summary>
        [Required(ErrorMessage = "分类编码不能为空")]
        [StringLength( 50, ErrorMessage = "分类编码输入过长，不能超过50位" )]
        [Display( Name = "分类编码" )]
        [DataMember]
        public string Code { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Required(ErrorMessage = "拼音简码不能为空")]
        [StringLength( 30, ErrorMessage = "拼音简码输入过长，不能超过30位" )]
        [Display( Name = "拼音简码" )]
        [DataMember]
        public string PinYin { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        [DataMember]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        [DataMember]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Required(ErrorMessage = "是否删除不能为空")]
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}