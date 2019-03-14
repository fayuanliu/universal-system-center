using System;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Domains.Factories {
    /// <summary>
    /// 消息工厂
    /// </summary>
    public static class MessageFactory {
        /// <summary>
        /// 创建消息
        /// </summary>
        /// <param name="messageId">消息编号（MessageId）</param>
        /// <param name="messageContentId">消息内容编号（MessageContentId）</param>
        /// <param name="receiver">接收人（Receiver）</param>
        /// <param name="receiverNo">接收编号</param>
        /// <param name="state">状态（State）</param>
        /// <param name="errorMsg">错误信息</param>
        /// <param name="readTime">查看时间（ReadTime）</param>
        /// <param name="sendTime">发送时间（SendTime）</param>
        /// <param name="isDeleted">是否删除</param>
        /// <param name="version">版本号</param>
        public static Message Create( 
            Guid messageId,
            Guid messageContentId,
            Guid receiver,
            string receiverNo,
            int state,
            string errorMsg,
            DateTime? readTime,
            DateTime? sendTime,
            bool isDeleted,
            Byte[] version
        ) {
            Message result;
            result = new Message( messageId );
            result.MessageContentId = messageContentId;
            result.Receiver = receiver;
            result.ReceiverNo = receiverNo;
            result.State = state;
            result.ErrorMsg = errorMsg;
            result.ReadTime = readTime;
            result.SendTime = sendTime;
            result.IsDeleted = isDeleted;
            result.Version = version;
            return result;
        }
    }
}