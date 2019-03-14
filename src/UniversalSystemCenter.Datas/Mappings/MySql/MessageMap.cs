using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 消息映射配置
    /// </summary>
    public class MessageMap : Util.Datas.Ef.MySql.AggregateRootMap<Message> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Message> builder ) {
            builder.ToTable( "dbo.Message" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Message> builder ) {
            //消息编号（MessageId）
            builder.Property(t => t.Id)
                .HasColumnName("MessageId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
