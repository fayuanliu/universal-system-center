using Util.Applications.Trees;
using UniversalSystemCenter.Service.Dtos;
using UniversalSystemCenter.Service.Queries;

namespace UniversalSystemCenter.Service.Abstractions {
    /// <summary>
    /// 菜单服务
    /// </summary>
    public interface IMenuService : ITreeService<MenuDto, MenuQuery> {
    }
}