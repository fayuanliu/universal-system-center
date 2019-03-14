using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using UniversalSystemCenter.Data;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;
using UniversalSystemCenter.Service.Abstractions;

namespace UniversalSystemCenter.Service.Implements {
    /// <summary>
    /// 消息类型服务
    /// </summary>
    public class MessageCategoryService : CrudServiceBase<MessageCategory, MessageCategoryDto, MessageCategoryQuery>, IMessageCategoryService {
        /// <summary>
        /// 初始化消息类型服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="messageCategoryRepository">消息类型仓储</param>
        public MessageCategoryService( IUniversalSysCenterUnitOfWork unitOfWork, IMessageCategoryRepository messageCategoryRepository )
            : base( unitOfWork, messageCategoryRepository ) {
            MessageCategoryRepository = messageCategoryRepository;
        }
        
        /// <summary>
        /// 消息类型仓储
        /// </summary>
        public IMessageCategoryRepository MessageCategoryRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<MessageCategory> CreateQuery( MessageCategoryQuery param ) {
            return new Query<MessageCategory>( param );
        }
    }
}