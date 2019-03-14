using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 消息模板映射配置
    /// </summary>
    public class MessageTemplateMap : Util.Datas.Ef.PgSql.AggregateRootMap<MessageTemplate> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<MessageTemplate> builder ) {
            builder.ToTable( "MessageTemplate", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<MessageTemplate> builder ) {
            //模板编号
            builder.Property(t => t.Id)
                .HasColumnName("TemplateId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
