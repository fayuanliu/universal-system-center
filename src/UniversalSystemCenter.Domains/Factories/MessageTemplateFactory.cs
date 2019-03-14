using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 消息模板工厂
    /// </summary>
    public static class MessageTemplateFactory {
        /// <summary>
        /// 创建消息模板
        /// </summary>
        /// <param name="templateId">模板编号</param>
        /// <param name="categoryId">所属消息分类</param>
        /// <param name="type">模板类型</param>
        /// <param name="sendObject">模板编码</param>
        /// <param name="name">模板名称</param>
        /// <param name="sourceId">资源编号</param>
        /// <param name="title">标题</param>
        /// <param name="content">模板内容</param>
        /// <param name="isEnabled">启用</param>
        /// <param name="sortId">排序号</param>
        /// <param name="creationTime">创建时间</param>
        /// <param name="creatorId">创建人</param>
        /// <param name="lastModifierId">最后修改人</param>
        /// <param name="lastModificationTime">最后修改时间</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static MessageTemplate Create( 
            Guid templateId,
            Guid categoryId,
            int type,
            Guid? sendObject,
            string name,
            string sourceId,
            string title,
            string content,
            byte isEnabled,
            int sortId,
            DateTime? creationTime,
            Guid? creatorId,
            Guid? lastModifierId,
            DateTime? lastModificationTime,
            bool isDeleted,
            Byte[] version
        ) {
            MessageTemplate result;
            result = new MessageTemplate( templateId );
            result.CategoryId = categoryId;
            result.Type = type;
            result.SendObject = sendObject;
            result.Name = name;
            result.SourceId = sourceId;
            result.Title = title;
            result.Content = content;
            result.IsEnabled = isEnabled;
            result.SortId = sortId;
            result.CreationTime = creationTime;
            result.CreatorId = creatorId;
            result.LastModifierId = lastModifierId;
            result.LastModificationTime = lastModificationTime;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}