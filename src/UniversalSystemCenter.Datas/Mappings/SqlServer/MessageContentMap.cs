using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.SqlServer {
    /// <summary>
    /// 消息内容表映射配置
    /// </summary>
    public class MessageContentMap : Util.Datas.Ef.SqlServer.AggregateRootMap<MessageContent> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<MessageContent> builder ) {
            builder.ToTable( "MessageContent", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<MessageContent> builder ) {
            //消息内容编号（MessageContentId）
            builder.Property(t => t.Id)
                .HasColumnName("MessageContentId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
