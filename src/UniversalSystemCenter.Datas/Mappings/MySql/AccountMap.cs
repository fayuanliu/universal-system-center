using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.MySql {
    /// <summary>
    /// 账户映射配置
    /// </summary>
    public class AccountMap : Util.Datas.Ef.MySql.AggregateRootMap<Account> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Account> builder ) {
            builder.ToTable( "Account" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Account> builder ) {
            //账户编号
            builder.Property(t => t.Id)
                .HasColumnName("AccountId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
