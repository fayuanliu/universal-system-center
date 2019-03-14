using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 菜单工厂
    /// </summary>
    public static class MenuFactory {
        /// <summary>
        /// 创建菜单
        /// </summary>
        /// <param name="menuId">菜单编号（MenuId)</param>
        /// <param name="appId">应用程序编号（AppId）</param>
        /// <param name="name">名称（Name）</param>
        /// <param name="isGroup">是否是菜单组（Group）</param>
        /// <param name="link">链接、路由（Link）</param>
        /// <param name="pathText">中文路径</param>
        /// <param name="icon">图标（Icon）</param>
        /// <param name="isLeave">是否末级</param>
        /// <param name="badge">徽章（Badge）</param>
        /// <param name="isOpen">是否隐藏（Hide）</param>
        /// <param name="code">分类编码</param>
        /// <param name="parentId">父编号</param>
        /// <param name="path">路径</param>
        /// <param name="level">级数</param>
        /// <param name="enabled">启用</param>
        /// <param name="sortId">排序号</param>
        /// <param name="pinYin">拼音简码</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static Menu Create( 
            Guid menuId,
            Guid? appId,
            string name,
            bool isGroup,
            string link,
            string pathText,
            string icon,
            bool isLeave,
            string badge,
            bool isOpen,
            string code,
            Guid? parentId,
            string path,
            int level,
            bool enabled,
            int sortId,
            string pinYin,
            DateTime? creationTime,
            Guid? creatorId,
            DateTime? lastModificationTime,
            Guid? lastModifierId,
            bool isDeleted,
            Byte[] version
        ) {
            Menu result;
            result = new Menu( menuId,"",0 );
            result.AppId = appId;
            result.Name = name;
            result.IsGroup = isGroup;
            result.Link = link;
            result.PathText = pathText;
            result.Icon = icon;
            result.IsLeave = isLeave;
            result.Badge = badge;
            result.IsOpen = isOpen;
            result.Code = code;
            result.ParentId = parentId;
            result.Enabled = enabled;
            result.SortId = sortId;
            result.PinYin = pinYin;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModificationTime = lastModificationTime;
            result.LastModifierId = lastModifierId;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}