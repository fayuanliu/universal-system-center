using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 消息内容表工厂
    /// </summary>
    public static class MessageContentFactory {
        /// <summary>
        /// 创建消息内容表
        /// </summary>
        /// <param name="messageContentId">消息内容编号（MessageContentId）</param>
        /// <param name="templateId">消息分类编号（MessageCategoryId）</param>
        /// <param name="title">消息标题（Title）</param>
        /// <param name="senderId">发送人编号（SenderId）</param>
        /// <param name="sender">发送人（Sender)</param>
        /// <param name="sendTime">发送时间（SendTime）</param>
        /// <param name="sourceId">业务编号（SourceId）</param>
        /// <param name="content">发送内容（Content）</param>
        /// <param name="url">业务地址（Url）</param>
        /// <param name="state">消息状态（State）</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="remark">备注</param>
        /// <param name="version">版本号</param>
        public static MessageContent Create( 
            Guid messageContentId,
            Guid templateId,
            string title,
            Guid? senderId,
            string sender,
            DateTime sendTime,
            Guid? sourceId,
            string content,
            string url,
            int state,
            bool isDeleted,
            string remark,
            Byte[] version
        ) {
            MessageContent result;
            result = new MessageContent( messageContentId );
            result.TemplateId = templateId;
            result.Title = title;
            result.SenderId = senderId;
            result.Sender = sender;
            result.SendTime = sendTime;
            result.SourceId = sourceId;
            result.Content = content;
            result.Url = url;
            result.State = state;
            result.IsDeleted = isDeleted;
            result.Remark = remark;
            result.Version = version;
            return result;
        }
    }
}