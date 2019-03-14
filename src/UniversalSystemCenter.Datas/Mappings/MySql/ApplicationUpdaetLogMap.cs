using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 应用更新日志映射配置
    /// </summary>
    public class ApplicationUpdaetLogMap : Util.Datas.Ef.MySql.AggregateRootMap<ApplicationUpdaetLog> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<ApplicationUpdaetLog> builder ) {
            builder.ToTable( "ApplicationUpdaetLog" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<ApplicationUpdaetLog> builder ) {
            //日志编号
            builder.Property(t => t.Id)
                .HasColumnName("LogId");
        }
    }
}
