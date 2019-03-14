using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 消息数据传输对象扩展
    /// </summary>
    public static class MessageDtoExtension {
        /// <summary>
        /// 转换为消息实体
        /// </summary>
        /// <param name="dto">消息数据传输对象</param>
        public static Message ToEntity( this MessageDto dto ) {
            if ( dto == null )
                return new Message();
            return dto.MapTo( new Message( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为消息实体
        /// </summary>
        /// <param name="dto">消息数据传输对象</param>
        public static Message ToEntity2( this MessageDto dto ) {
            if( dto == null )
                return new Message();
            return new Message( dto.Id.ToGuid() ) {
                MessageContentId = dto.MessageContentId,
                Receiver = dto.Receiver,
                ReceiverNo = dto.ReceiverNo,
                State = dto.State,
                ErrorMsg = dto.ErrorMsg,
                ReadTime = dto.ReadTime,
                SendTime = dto.SendTime,
                IsDeleted = dto.IsDeleted,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为消息实体
        /// </summary>
        /// <param name="dto">消息数据传输对象</param>
        public static Message ToEntity3( this MessageDto dto ) {
            if( dto == null )
                return new Message();
            return MessageFactory.Create(
                messageId : dto.Id.ToGuid(),
                messageContentId : dto.MessageContentId,
                receiver : dto.Receiver,
                receiverNo : dto.ReceiverNo,
                state : dto.State,
                errorMsg : dto.ErrorMsg,
                readTime : dto.ReadTime,
                sendTime : dto.SendTime,
                isDeleted : dto.IsDeleted,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为消息数据传输对象
        /// </summary>
        /// <param name="entity">消息实体</param>
        public static MessageDto ToDto(this Message entity) {
            if( entity == null )
                return new MessageDto();
            return entity.MapTo<MessageDto>();
        }

        /// <summary>
        /// 转换为消息数据传输对象
        /// </summary>
        /// <param name="entity">消息实体</param>
        public static MessageDto ToDto2( this Message entity ) {
            if( entity == null )
                return new MessageDto();
            return new MessageDto {
                Id = entity.Id.ToString(),
                MessageContentId = entity.MessageContentId,
                Receiver = entity.Receiver,
                ReceiverNo = entity.ReceiverNo,
                State = entity.State,
                ErrorMsg = entity.ErrorMsg,
                ReadTime = entity.ReadTime,
                SendTime = entity.SendTime,
                IsDeleted = entity.IsDeleted,
                Version = entity.Version,
            };
        }
    }
}