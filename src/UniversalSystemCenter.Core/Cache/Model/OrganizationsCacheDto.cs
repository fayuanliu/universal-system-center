using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Model
{
    /// <summary>
    /// 组织部门缓存模型
    /// </summary>
    public class OrganizationsCacheDto
    {
        public int Id { get; set; }
        /// <summary>
        /// 名称（Name）
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 类型（Type）
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int? State { get; set; }
        /// <summary>
        /// 是否隐藏（Hide）
        /// </summary>
        public bool IsOpen { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        public bool IsLeave { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        public string PinYin { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        public string LastModifierId { get; set; }
        /// <summary>
        /// 区域Regionid
        /// </summary>
        public string RegionId { get; set; }
        /// <summary>
        /// 省Province
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 市City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 区Quarter
        /// </summary>
        public string Quarter { get; set; }
        /// <summary>
        /// AddressDetails
        /// </summary>
        public string AddressDetail { get; set; }
        /// <summary>
        /// 推荐部门
        /// </summary>
        public int? ReferenceDetpId { get; set; }
        /// <summary>
        /// 部门全路径
        /// </summary>
        public string FullPath { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 部门负责人
        /// </summary>
        public int? OrgChargeUid { get; set; }
        /// <summary>
        /// 部门推荐人
        /// </summary>
        public int? ReferenceUid { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        //[Required]
        public virtual string Path { get; set; }

        /// <summary>
        /// 级数
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int SortId { get; set; }

        /// <summary>
        /// 父级int
        /// </summary>
        public string ParentId { get; set; }
    }
}
