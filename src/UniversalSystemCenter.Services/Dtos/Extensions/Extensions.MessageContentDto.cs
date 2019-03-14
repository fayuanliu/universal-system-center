using Util;
using Util.Maps;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domains.Factories;

namespace UniversalSystemCenter.Service.Dtos.Extensions {
    /// <summary>
    /// 消息内容表数据传输对象扩展
    /// </summary>
    public static class MessageContentDtoExtension {
        /// <summary>
        /// 转换为消息内容表实体
        /// </summary>
        /// <param name="dto">消息内容表数据传输对象</param>
        public static MessageContent ToEntity( this MessageContentDto dto ) {
            if ( dto == null )
                return new MessageContent();
            return dto.MapTo( new MessageContent( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为消息内容表实体
        /// </summary>
        /// <param name="dto">消息内容表数据传输对象</param>
        public static MessageContent ToEntity2( this MessageContentDto dto ) {
            if( dto == null )
                return new MessageContent();
            return new MessageContent( dto.Id.ToGuid() ) {
                TemplateId = dto.TemplateId,
                Title = dto.Title,
                SenderId = dto.SenderId,
                Sender = dto.Sender,
                SendTime = dto.SendTime,
                SourceId = dto.SourceId,
                Content = dto.Content,
                Url = dto.Url,
                State = dto.State,
                IsDeleted = dto.IsDeleted,
                Remark = dto.Remark,
                Version = dto.Version,
            };
        }
        
        /// <summary>
        /// 转换为消息内容表实体
        /// </summary>
        /// <param name="dto">消息内容表数据传输对象</param>
        public static MessageContent ToEntity3( this MessageContentDto dto ) {
            if( dto == null )
                return new MessageContent();
            return MessageContentFactory.Create(
                messageContentId : dto.Id.ToGuid(),
                templateId : dto.TemplateId,
                title : dto.Title,
                senderId : dto.SenderId,
                sender : dto.Sender,
                sendTime : dto.SendTime,
                sourceId : dto.SourceId,
                content : dto.Content,
                url : dto.Url,
                state : dto.State,
                isDeleted : dto.IsDeleted,
                remark : dto.Remark,
                version : dto.Version
            );
        }
        
        /// <summary>
        /// 转换为消息内容表数据传输对象
        /// </summary>
        /// <param name="entity">消息内容表实体</param>
        public static MessageContentDto ToDto(this MessageContent entity) {
            if( entity == null )
                return new MessageContentDto();
            return entity.MapTo<MessageContentDto>();
        }

        /// <summary>
        /// 转换为消息内容表数据传输对象
        /// </summary>
        /// <param name="entity">消息内容表实体</param>
        public static MessageContentDto ToDto2( this MessageContent entity ) {
            if( entity == null )
                return new MessageContentDto();
            return new MessageContentDto {
                Id = entity.Id.ToString(),
                TemplateId = entity.TemplateId,
                Title = entity.Title,
                SenderId = entity.SenderId,
                Sender = entity.Sender,
                SendTime = entity.SendTime,
                SourceId = entity.SourceId,
                Content = entity.Content,
                Url = entity.Url,
                State = entity.State,
                IsDeleted = entity.IsDeleted,
                Remark = entity.Remark,
                Version = entity.Version,
            };
        }
    }
}