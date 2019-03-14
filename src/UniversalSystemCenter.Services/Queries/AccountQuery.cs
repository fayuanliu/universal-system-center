using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace UniversalSystemCenter.Service.Queries {
    /// <summary>
    /// 账户查询参数
    /// </summary>
    public class AccountQuery : QueryParameter {
        /// <summary>
        /// 账户编号
        /// </summary>
        [Display(Name="账户编号")]
        public Guid? AccountId { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name="类型")]
        public int? Type { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? State { get; set; }
        
        private string _nickname = string.Empty;
        /// <summary>
        /// 昵称
        /// </summary>
        [Display(Name="昵称")]
        public string Nickname {
            get => _nickname == null ? string.Empty : _nickname.Trim();
            set => _nickname = value;
        }
        
        private string _password = string.Empty;
        /// <summary>
        /// 密码（Password）
        /// </summary>
        [Display(Name="密码（Password）")]
        public string Password {
            get => _password == null ? string.Empty : _password.Trim();
            set => _password = value;
        }
        
        private string _head = string.Empty;
        /// <summary>
        /// 头像（Head）
        /// </summary>
        [Display(Name="头像（Head）")]
        public string Head {
            get => _head == null ? string.Empty : _head.Trim();
            set => _head = value;
        }
        
        private string _mobile = string.Empty;
        /// <summary>
        /// 手机号
        /// </summary>
        [Display(Name="手机号")]
        public string Mobile {
            get => _mobile == null ? string.Empty : _mobile.Trim();
            set => _mobile = value;
        }
        
        private string _saltd = string.Empty;
        /// <summary>
        /// 盐值
        /// </summary>
        [Display(Name="盐值")]
        public string Saltd {
            get => _saltd == null ? string.Empty : _saltd.Trim();
            set => _saltd = value;
        }
        
        private string _idCard = string.Empty;
        /// <summary>
        /// 用户编号
        /// </summary>
        [Display(Name="用户编号")]
        public string IdCard {
            get => _idCard == null ? string.Empty : _idCard.Trim();
            set => _idCard = value;
        }
        
        private string _realName = string.Empty;
        /// <summary>
        /// 真实姓名
        /// </summary>
        [Display(Name="真实姓名")]
        public string RealName {
            get => _realName == null ? string.Empty : _realName.Trim();
            set => _realName = value;
        }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name="性别")]
        public int? Sex { get; set; }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreationTime { get; set; }
        
        private string _creatorId = string.Empty;
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public string CreatorId {
            get => _creatorId == null ? string.Empty : _creatorId.Trim();
            set => _creatorId = value;
        }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display( Name = "起始最后修改时间" )]
        public DateTime? BeginLastModificationTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display( Name = "结束最后修改时间" )]
        public DateTime? EndLastModificationTime { get; set; }
        
        private string _lastModifierId = string.Empty;
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display(Name="最后修改人")]
        public string LastModifierId {
            get => _lastModifierId == null ? string.Empty : _lastModifierId.Trim();
            set => _lastModifierId = value;
        }
    }
}