﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UniversalSystemCenter.Domain.Models;

namespace UniversalSystemCenter.Data.Mappings.PgSql {
    /// <summary>
    /// 角色映射配置
    /// </summary>
    public class RoleMap : Util.Datas.Ef.PgSql.AggregateRootMap<Role> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Role> builder ) {
            builder.ToTable( "Role", "dbo" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Role> builder ) {
            //类型编号（TypeId）
            builder.Property(t => t.Id)
                .HasColumnName("RoleId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
