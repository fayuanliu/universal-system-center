using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries.Trees;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 菜单查询参数
    /// </summary>
    public class MenuQuery : TreeQueryParameter {
        /// <summary>
        /// 菜单编号（MenuId)
        /// </summary>
        [Display(Name="菜单编号（MenuId)")]
        public Guid? MenuId { get; set; }
        /// <summary>
        /// 应用程序编号（AppId）
        /// </summary>
        [Display(Name="应用程序编号（AppId）")]
        public Guid? AppId { get; set; }
        
        private string _name = string.Empty;
        /// <summary>
        /// 名称（Name）
        /// </summary>
        [Display(Name="名称（Name）")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        }
        /// <summary>
        /// 是否是菜单组（Group）
        /// </summary>
        [Display(Name="是否是菜单组（Group）")]
        public byte? IsGroup { get; set; }
        
        private string _link = string.Empty;
        /// <summary>
        /// 链接、路由（Link）
        /// </summary>
        [Display(Name="链接、路由（Link）")]
        public string Link {
            get => _link == null ? string.Empty : _link.Trim();
            set => _link = value;
        }
        
        private string _pathText = string.Empty;
        /// <summary>
        /// 中文路径
        /// </summary>
        [Display(Name="中文路径")]
        public string PathText {
            get => _pathText == null ? string.Empty : _pathText.Trim();
            set => _pathText = value;
        }
        
        private string _icon = string.Empty;
        /// <summary>
        /// 图标（Icon）
        /// </summary>
        [Display(Name="图标（Icon）")]
        public string Icon {
            get => _icon == null ? string.Empty : _icon.Trim();
            set => _icon = value;
        }
        /// <summary>
        /// 是否末级
        /// </summary>
        [Display(Name="是否末级")]
        public byte? IsLeave { get; set; }
        
        private string _badge = string.Empty;
        /// <summary>
        /// 徽章（Badge）
        /// </summary>
        [Display(Name="徽章（Badge）")]
        public string Badge {
            get => _badge == null ? string.Empty : _badge.Trim();
            set => _badge = value;
        }
        /// <summary>
        /// 是否隐藏（Hide）
        /// </summary>
        [Display(Name="是否隐藏（Hide）")]
        public byte? IsOpen { get; set; }
        
        private string _code = string.Empty;
        /// <summary>
        /// 分类编码
        /// </summary>
        [Display(Name="分类编码")]
        public string Code {
            get => _code == null ? string.Empty : _code.Trim();
            set => _code = value;
        }
        
        private string _path = string.Empty;
        /// <summary>
        /// 路径
        /// </summary>
        [Display(Name="路径")]
        public string Path {
            get => _path == null ? string.Empty : _path.Trim();
            set => _path = value;
        }
        /// <summary>
        /// 启用
        /// </summary>
        [Display(Name="启用")]
        public byte? Enabled { get; set; }
        
        private string _pinYin = string.Empty;
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Display(Name="拼音简码")]
        public string PinYin {
            get => _pinYin == null ? string.Empty : _pinYin.Trim();
            set => _pinYin = value;
        }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreationTime { get; set; }        
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display( Name = "起始最后修改时间" )]
        public DateTime? BeginLastModificationTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display( Name = "结束最后修改时间" )]
        public DateTime? EndLastModificationTime { get; set; }        
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display(Name="最后修改人")]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name="是否删除")]
        public byte? IsDeleted { get; set; }
    }
}