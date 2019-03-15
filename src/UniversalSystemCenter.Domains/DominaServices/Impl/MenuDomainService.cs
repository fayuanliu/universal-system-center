using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniversalSystemCenter.Domain.Models;
using UniversalSystemCenter.Domain.Repositories;
using UniversalSystemCenter.Domains.DominaServices.Interface;
using UniversalSystemCenter.Domains.DominaServices.Param;

namespace UniversalSystemCenter.Domains.DominaServices.Impl
{
    /// <summary>
    /// 菜单领域服务
    /// </summary>
    public class MenuDomainService : IMenuDomainService
    {
        /// <summary>
        /// 菜单
        /// </summary>
        private IMenuRepository _menuRepository { get; set; }
        public MenuDomainService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        /// <summary>
        /// 获取角色菜单
        /// </summary>
        /// <param name="roleIdList"></param>
        /// <returns></returns>
        public List<MenuShortDto> GetRoleMenus(List<Guid> roleIdList, Guid appId)
        {
            var dataMenus = _menuRepository.FindAsNoTracking().Where(a => a.RoleMenus.Any(b => roleIdList.Contains(b.RoleId)) && a.AppId == appId).OrderBy(a => a.SortId).ToList();
            List<MenuShortDto> menuShorList = new List<MenuShortDto>();
            foreach (var item in dataMenus.Where(a => a.ParentId == null))
            {
                MenuShortDto catalogShort = new MenuShortDto();
                GetTree(item, catalogShort, dataMenus);
                menuShorList.Add(catalogShort);
            }
            return menuShorList;
        }


        /// <summary>
        /// 获取所有树形菜单
        /// </summary>
        /// <returns></returns>
        public List<MenuShortDto> LoadTree(Guid appId)
        {
            var dataMenus = _menuRepository.FindAsNoTracking().Where(a => a.IsDeleted == false && a.AppId == appId).OrderBy(a => a.SortId).ToList();
            List<MenuShortDto> menuShorList = new List<MenuShortDto>();
            foreach (var item in dataMenus.Where(a => a.ParentId == null))
            {
                MenuShortDto catalogShort = new MenuShortDto();
                GetTree(item, catalogShort, dataMenus);
                menuShorList.Add(catalogShort);
            }
            return menuShorList;
        }

        /// <summary>
        /// 树形菜单递归
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="treeModel"></param>
        /// <param name="list"></param>
        private void GetTree(Menu menu, MenuShortDto treeModel, List<Menu> list)
        {
            if (null == menu)
            {
                return;
            }
            treeModel.Id = menu.Id.ToString();
            treeModel.Name = menu.Name;
            treeModel.Group = menu.IsGroup;
            treeModel.Link = menu.Link;
            treeModel.Icon = menu.Icon;
            var childs = list.Where(a => a.ParentId == menu.Id).ToArray();
            foreach (var child in childs)
            {
                MenuShortDto node = new MenuShortDto();
                treeModel.Children.Add(node);
                GetTree(child, node, list);
            }
        }
    }
}
